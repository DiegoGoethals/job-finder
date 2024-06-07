using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Pri.Api.Pe.Api.Dtos;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Pri.Api.Pe.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountsController(IAccountService accountService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _accountService = accountService;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(AccountRequestDto accountRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _signInManager.PasswordSignInAsync(accountRequestDto.UserName, accountRequestDto.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Wrong credentials!");
                return BadRequest(ModelState);
            }
            var user = await _userManager.FindByNameAsync(accountRequestDto.UserName);

            var claims = await _userManager.GetClaimsAsync(user);

            var issuer = _configuration.GetValue<string>("JWTConfiguration:Issuer");
            var audience = _configuration.GetValue<string>("JWTConfiguration:Audience");
            var expiration = DateTime.Now.AddDays(_configuration.GetValue<int>("JWTConfiguration:ExpirationInDays"));
            var key = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SecretKey"));
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            var signinCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                notBefore: DateTime.Now,
                expires: expiration,
                claims: claims,
                signingCredentials: signinCredentials
                );

            var serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new AccountResponseDto { Id = user.Id, UserName = user.UserName, Token = serializedToken });
    }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegistrationRequestDto registrationRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _userManager.FindByNameAsync(registrationRequestDto.UserName) == null)
            {
                var user = new ApplicationUser
                {
                    UserName = registrationRequestDto.UserName,
                    Email = registrationRequestDto.Email,
                    Firstname = registrationRequestDto.Firstname,
                    Lastname = registrationRequestDto.Lastname,
                    Skills = new List<Skill>(),
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Birthday = registrationRequestDto.Birthday
                };

                var registrationResult = await _accountService.Register(user, registrationRequestDto.Skills);

                if (registrationResult.IsSucces)
                {
                    var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                    if (result.Succeeded)
                    {
                        _ = await _userManager.AddToRoleAsync(user, registrationRequestDto.Role);

                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Role, registrationRequestDto.Role),
                            new Claim(ClaimTypes.DateOfBirth, user.Birthday.ToString()),
                            new Claim(ClaimTypes.Name, user.UserName),
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                        };

                        result = await _userManager.AddClaimsAsync(user, claims);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                            return BadRequest(ModelState);
                        }

                        return CreatedAtAction(nameof(Register), new { id = registrationResult.Value.Id }, new RegistrationResponseDto
                        {
                            Id = registrationResult.Value.Id,
                            UserName = registrationResult.Value.UserName
                        });
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return BadRequest(ModelState);
                    }
                }
            }
            return BadRequest();
        }
    }
}
