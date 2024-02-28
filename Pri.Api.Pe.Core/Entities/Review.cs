using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Entities
{
    public class Review : BaseEntity
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Guid ReviewerId { get; set; }
        public Guid RevieweeId { get; set; }
        public ApplicationUser Reviewer { get; set; }
        public ApplicationUser Reviewee { get; set; }
    }
}
