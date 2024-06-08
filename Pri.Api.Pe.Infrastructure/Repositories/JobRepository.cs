using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Infrastructure.Data;

namespace Pri.Api.Pe.Infrastructure.Repositories
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Job>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async override Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _table.Include(j => j.Applications)
                .ThenInclude(a => a.Candidate)
                .Include(j => j.Applications)
                .ThenInclude(a => a.Status)
                .ToListAsync();
        }
    }
}
