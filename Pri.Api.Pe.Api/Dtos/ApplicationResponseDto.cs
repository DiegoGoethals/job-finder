namespace Pri.Api.Pe.Api.Dtos
{
    public class ApplicationResponseDto
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid CandidateId { get; set; }
        public double Salary { get; set; }
        public string ApplicationStatus { get; set; }
    }
}
