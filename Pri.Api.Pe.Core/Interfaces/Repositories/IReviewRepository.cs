using Pri.Api.Pe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Repositories
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        Task<IEnumerable<Review>> GetByRevieweeIdAsync(Guid revieweeId);
        Task<IEnumerable<Review>> GetByReviewerIdAsync(Guid reviewerId);
    }
}
