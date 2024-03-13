using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Pri.Api.Pe.Api.Dtos;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Infrastructure.Data;
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
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountsController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _applicationDbContext = applicationDbContext;
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
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(u => u.UserName == accountRequestDto.UserName);

            return Ok(
                new AccountResponseDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Token = GenerateJwtToken(user)
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

        private string GenerateSecretKey(int keyLength)
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
                    Lastname = registrationRequestDto.Lastname
                };
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, registrationRequestDto.Role);

                    foreach (var skillName in registrationRequestDto.Skills)
                    {
                        var skill = _applicationDbContext.Skills.FirstOrDefault(sk => sk.Name == skillName);
                        if (skill != null)
                        {
                            user.Skills.Add(skill);
                        }
                    }
                    await _applicationDbContext.SaveChangesAsync();
                    return CreatedAtAction(nameof(Register), new { id = user.Id }, user); // To do, change this to return a DTO
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
            return BadRequest();
        }
    }
}
