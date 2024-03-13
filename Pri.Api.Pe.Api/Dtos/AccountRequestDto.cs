using System.ComponentModel.DataAnnotations;

namespace Pri.Api.Pe.Api.Dtos
{
    public class AccountRequestDto
    {
        [Required(ErrorMessage = "Username missing!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password missing!")]
        public string Password { get; set; }
    }
}
