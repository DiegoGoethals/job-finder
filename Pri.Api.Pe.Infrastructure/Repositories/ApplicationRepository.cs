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
    public class ApplicationRepository : BaseRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Application>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async Task<IEnumerable<Application>> GetAllByJobAsync(Guid jobId)
        {
            return await _table
                .Where(t => t.JobId == jobId)
                .Include(t => t.Status)
                .Include(t => t.Candidate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Application>> GetAllByCandidateAsync(Guid candidateId)
        {
            return await _table
                .Where(t => t.CandidateId == candidateId)
                .Include(t => t.Status)
                .ToListAsync();
        }
    }
}
