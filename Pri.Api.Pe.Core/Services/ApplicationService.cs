using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;

namespace Pri.Api.Pe.Core.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IJobRepository _jobRepository;

        public ApplicationService(IApplicationRepository applicationRepository, IJobRepository jobRepository)
        {
            _applicationRepository = applicationRepository;
            _jobRepository = jobRepository;
        }

        public async Task<ResultModel<Application>> CreateAsync(Guid jobId, Guid candidateId, double salary)
        {
            var job = await _jobRepository.GetByIdAsync(jobId);
            if (job == null)
            {
                return new ResultModel<Application>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Job not found" }
                };
            }

            var application = new Application
            {
                Id = Guid.NewGuid(),
                JobId = jobId,
                CandidateId = candidateId,
                Salary = salary
            };

            if (await _applicationRepository.AddAsync(application))
            {
                return new ResultModel<Application>
                {
                    Value = application,
                    IsSucces = true
                };
            }
            return new ResultModel<Application>
            {
                IsSucces = false,
                Errors = new List<string> { "Error creating application" }
            };
        }

        public async Task<ResultModel<IEnumerable<Application>>> GetAllByJobAsync(Guid jobId)
        {
            var applications = await _applicationRepository.GetAllByJobAsync(jobId);
            if (applications.Any())
            {
                return new ResultModel<IEnumerable<Application>>
                {
                    Value = applications,
                    IsSucces = true
                };
            }
            return new ResultModel<IEnumerable<Application>>
            {
                IsSucces = false,
                Errors = new List<string> { "No applications found" }
            };
        }

        public async Task<ResultModel<Application>> DeleteAsync(Guid id)
        {
            var application = await _applicationRepository.GetByIdAsync(id);
            if (application == null)
            {
                return new ResultModel<Application>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Application not found" }
                };
            }
            if (await _applicationRepository.DeleteAsync(application))
            {
                return new ResultModel<Application>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Application>
            {
                IsSucces = false,
                Errors = new List<string> { "Error deleting application" }
            };
        }

        public async Task<ResultModel<IEnumerable<Application>>> GetAllByCandidateAsync(Guid candidateId)
        {
            var applications = await _applicationRepository.GetAllByCandidateAsync(candidateId);
            if (applications.Any())
            {
                return new ResultModel<IEnumerable<Application>>
                {
                    Value = applications,
                    IsSucces = true
                };
            }
            return new ResultModel<IEnumerable<Application>>
            {
                IsSucces = false,
                Errors = new List<string> { "No applications found" }
            };
        }

        public async Task<ResultModel<Application>> GetByIdAsync(Guid id)
        {
            var application = await _applicationRepository.GetByIdAsync(id);
            if (application == null)
            {
                return new ResultModel<Application>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Application not found" }
                };
            }
            return new ResultModel<Application>
            {
                Value = application,
                IsSucces = true
            };
        }

        public async Task<ResultModel<Application>> UpdateAsync(Guid id, double salary)
        {
            var application = await _applicationRepository.GetByIdAsync(id);
            if (application == null)
            {
                return new ResultModel<Application>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Application not found" }
                };
            }
            application.Salary = salary;
            if (await _applicationRepository.UpdateAsync(application))
            {
                return new ResultModel<Application>
                {
                    Value = application,
                    IsSucces = true
                };
            }
            return new ResultModel<Application>
            {
                IsSucces = false,
                Errors = new List<string> { "Error updating application" }
            };
        }
    }
}
