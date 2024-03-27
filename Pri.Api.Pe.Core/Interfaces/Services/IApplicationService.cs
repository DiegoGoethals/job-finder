using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Services.Models;

namespace Pri.Api.Pe.Core.Interfaces.Services
{
    public interface IApplicationService
    {
        Task<ResultModel<Application>> CreateAsync(Guid jobId, Guid candidateId, double salary);
        Task<ResultModel<IEnumerable<Application>>> GetAllByJobAsync(Guid jobId);
        Task<ResultModel<Application>> DeleteAsync(Guid id);
        Task<ResultModel<IEnumerable<Application>>> GetAllByCandidateAsync(Guid candidateId);
        Task<ResultModel<Application>> GetByIdAsync(Guid id);
        Task<ResultModel<Application>> UpdateAsync(Guid id, double salary);
        Task<ResultModel<Application>> HandleApplication(Guid id, ApplicationStatus status);
        Task<ApplicationStatus> MapDtoToEntity(string status);
    }
}
