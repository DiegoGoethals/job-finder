namespace Pri.Api.Pe.Api.Dtos
{
    public class MessageRequestDto
    {
        public string Content { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
    }
}
