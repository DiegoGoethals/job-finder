using Microsoft.EntityFrameworkCore;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;

namespace Pri.Api.Pe.Core.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly ISkillRepository _skillRepository;

        public JobService(IJobRepository jobRepository, ISkillRepository skillRepository)
        {
            _jobRepository = jobRepository;
            _skillRepository = skillRepository;
        }

        public async Task<ResultModel<Job>> CreateAsync(string name, string description, double salary, Guid employerId, IEnumerable<string> skills)
        {
            var job = new Job
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                Salary = salary,
                EmployerId = employerId,
                Skills = new List<Skill>()
            };

            foreach (var skillName in skills)
            {
                var skill = _skillRepository.GetAll().FirstOrDefault(s => s.Name == skillName);
                if (skill != null)
                {
                    job.Skills.Add(skill);
                }
            }

            if (await _jobRepository.AddAsync(job))
            {
                return new ResultModel<Job>
                {
                    Value = job,
                    IsSucces = true
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string> { "Error creating job" }
            };
        }

        public async Task<ResultModel<Job>> DeleteAsync(Guid id)
        {
            var job = await _jobRepository.GetByIdAsync(id);
            if (job == null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Job not found" }
                };
            }
            if (await _jobRepository.DeleteAsync(job))
            {
                return new ResultModel<Job>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string> { "Error deleting job" }
            };
        }

        public async Task<ResultModel<IEnumerable<Job>>> GetAllAsync()
        {
            var jobs = await _jobRepository.GetAllAsync();
            if (jobs.Any())
            {
                return new ResultModel<IEnumerable<Job>>
                {
                    Value = jobs,
                    IsSucces = true
                };
            }
            return new ResultModel<IEnumerable<Job>>
            {
                IsSucces = true,
                Value = new List<Job>()
            };
        }

        public async Task<ResultModel<IEnumerable<Job>>> GetBySkills(IEnumerable<string> skills)
        {
            var jobs = _jobRepository.GetAll();
            var jobsWithSkills = jobs.Include(job => job.Skills).ToList();
            var filteredJobs = jobsWithSkills
                .Where(job => job.Skills != null && job.Skills.Any(s => skills.Contains(s.Name)))
                .ToList();
            if (filteredJobs.Any())
            {
                return new ResultModel<IEnumerable<Job>>
                {
                    Value = filteredJobs,
                    IsSucces = true
                };
            }
            return new ResultModel<IEnumerable<Job>>
            {
                IsSucces = true,
                Value = new List<Job>()
            };
        }

        public async Task<ResultModel<Job>> GetByIdAsync(Guid id)
        {
            var job = await _jobRepository.GetByIdAsync(id);
            if (job != null)
            {
                return new ResultModel<Job>
                {
                    Value = job,
                    IsSucces = true
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string> { "Job not found" }
            };
        }

        public async Task<ResultModel<Job>> UpdateAsync(Guid id, string name, string description, double salary, IEnumerable<string> skills)
        {
            var job = await _jobRepository.GetByIdAsync(id);
            if (job == null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Job not found" }
                };
            }

            job.Name = name;
            job.Description = description;
            job.Salary = salary;
            job.Skills = new List<Skill>();

            foreach (var skillName in skills)
            {
                var skill = _skillRepository.GetAll().FirstOrDefault(s => s.Name == skillName);
                if (skill != null)
                {
                    job.Skills.Add(skill);
                }
            }

            if (await _jobRepository.UpdateAsync(job))
            {
                return new ResultModel<Job>
                {
                    Value = job,
                    IsSucces = true
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string> { "Error updating job" }
            };
        }
    }
}
