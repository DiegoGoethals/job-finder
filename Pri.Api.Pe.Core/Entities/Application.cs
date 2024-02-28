using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Entities
{
    public class Application : BaseEntity
    {
        public double Salary { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public Guid CandidateId { get; set; }
        public ApplicationUser Candidate { get; set; }
        public Guid StatusId { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
