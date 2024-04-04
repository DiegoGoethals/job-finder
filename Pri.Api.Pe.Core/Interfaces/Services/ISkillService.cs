using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface ISkillService
    {
        Task<ResultModel<Skill>> CreateAsync(string name);
        Task<ResultModel<IEnumerable<Skill>>> GetAllAsync();
        Task<ResultModel<Skill>> GetByIdAsync(Guid id);
        Task<ResultModel<Skill>> UpdateAsync(Guid id, string name);
        Task<ResultModel<Skill>> DeleteAsync(Guid id);
    }
}
