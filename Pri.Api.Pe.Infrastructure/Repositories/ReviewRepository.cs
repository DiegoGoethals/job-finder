using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Review>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async Task<IEnumerable<Review>> GetByRevieweeIdAsync(Guid revieweeId)
        {
            return await _table.Where(x => x.RevieweeId == revieweeId).ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetByReviewerIdAsync(Guid reviewerId)
        {
            return await _table.Where(x => x.ReviewerId == reviewerId).ToListAsync();
        }
    }
}
