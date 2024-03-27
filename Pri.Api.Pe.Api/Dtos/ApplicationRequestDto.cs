namespace Pri.Api.Pe.Api.Dtos
{
    public class ApplicationRequestDto
    {
        public Guid JobId { get; set; }
        public Guid CandidateId { get; set; }
        public double Salary { get; set; }
    }
}
