using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Pri.Api.Pe.Api.Dtos;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Pri.Api.Pe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountsController(IAccountService accountService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _accountService = accountService;
            _userManager = userManager;
            _signInManager = signInManager;
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
            var user = await _accountService.GetByUserNameAsync(accountRequestDto.UserName);

            return Ok(
                new AccountResponseDto
                {
                    Id = user.Value.Id,
                    UserName = user.Value.UserName,
                    Token = GenerateJwtToken((ApplicationUser)user.Value)
                }
            );
        }

        private string GenerateJwtToken(ApplicationUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(GenerateSecretKey(32));
            var userRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, userRole)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static string GenerateSecretKey(int keyLength)
        {
            byte[] keyBytes = new byte[keyLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(keyBytes);
            }
            return Convert.ToBase64String(keyBytes);
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
                    Skills = new List<Skill>()
                };

                var registrationResult = await _accountService.Register(user, registrationRequestDto.Skills);

                if (registrationResult.IsSucces)
                {
                    var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                    if (result.Succeeded)
                    {
                        _ = await _userManager.AddToRoleAsync(user, registrationRequestDto.Role);

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
