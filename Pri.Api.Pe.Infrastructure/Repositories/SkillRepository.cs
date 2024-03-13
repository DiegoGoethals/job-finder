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
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        public SkillRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Skill>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public async Task<Skill> GetByName(string name)
        {
            return await _table
                .FirstOrDefaultAsync(t => t.Name == name);
        }
    }
}
