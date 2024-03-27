using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Infrastructure.Data;

namespace Pri.Api.Pe.Infrastructure.Repositories
{
    public class ApplicationStatusRepository : BaseRepository<ApplicationStatus>, IApplicationStatusRepository
    {
        public ApplicationStatusRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<ApplicationStatus>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async Task<ApplicationStatus> GetByNameAsync(string name)
        {
            return  _table.FirstOrDefault(s => s.Name == name);
        }
    }
}
