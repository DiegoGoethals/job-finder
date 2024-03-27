using Pri.Api.Pe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Interfaces.Repositories
{
    public interface IApplicationRepository : IBaseRepository<Application>
    {
        Task<IEnumerable<Application>> GetAllByJobAsync(Guid jobId);
        Task<IEnumerable<Application>> GetAllByCandidateAsync(Guid candidateId);
    }
}
