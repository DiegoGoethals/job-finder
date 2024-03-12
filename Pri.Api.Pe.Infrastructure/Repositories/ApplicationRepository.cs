using Microsoft.Extensions.Logging;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces;
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
    }
}
