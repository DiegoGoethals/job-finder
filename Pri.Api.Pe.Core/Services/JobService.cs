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
    }
}
