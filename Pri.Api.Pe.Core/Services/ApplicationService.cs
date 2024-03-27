﻿using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;

namespace Pri.Api.Pe.Core.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IJobRepository _jobRepository;
        private readonly IApplicationStatusRepository _applicationStatusRepository;

        public ApplicationService(IApplicationRepository applicationRepository, IJobRepository jobRepository, IApplicationStatusRepository applicationStatusRepository)
        {
            _applicationRepository = applicationRepository;
            _jobRepository = jobRepository;
            _applicationStatusRepository = applicationStatusRepository;
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
                Salary = salary,
                Status = ApplicationStatus.Pending
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

        public async Task<ApplicationStatus> MapDtoToEntity(string status)
        {
            return await _applicationStatusRepository.GetByNameAsync(status);
        }

        public async Task<ResultModel<Application>> HandleApplication(Guid id, ApplicationStatus status)
        {
            var application = await _applicationRepository.GetByIdAsync(id);
            var statusExists = _applicationStatusRepository.GetAll().Any(s => s == status);
            if (application == null || !statusExists)
            {
                return new ResultModel<Application>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Application not found" }
                };
            }
            application.Status = status;
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
                Errors = new List<string> { "Error handling application" }
            };
        }
    }
}
