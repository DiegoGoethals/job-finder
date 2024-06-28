namespace Pri.Api.Pe.Api.Dtos
{
    public class UserDetailsResponseDto
    {
        public string UserName { get; set; }
        public ICollection<string> Skills { get; set; }
        public ICollection<ReviewResponseDto> Reviews { get; set; }
    }
}
