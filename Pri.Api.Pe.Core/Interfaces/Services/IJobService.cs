using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IJobService
    {
        Task<ResultModel<Job>> CreateAsync(string name, string description, double salary, Guid employerId, IEnumerable<string> skills);
        Task<ResultModel<Job>> DeleteAsync(Guid id);
        Task<ResultModel<IEnumerable<Job>>> GetAllAsync();
        Task<ResultModel<IEnumerable<Job>>> GetBySkills(IEnumerable<string> skills);
        Task<ResultModel<Job>> GetByIdAsync(Guid id);
        Task<ResultModel<Job>> UpdateAsync(Guid id, string name, string description, double salary, IEnumerable<string> skills);
    }
}
