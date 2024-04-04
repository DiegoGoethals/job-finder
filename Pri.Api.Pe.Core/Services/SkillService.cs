using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Repositories;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Api.Pe.Core.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<ResultModel<Skill>> CreateAsync(string name)
        {
            var skill = new Skill
            {
                Id = Guid.NewGuid(),
                Name = name
            };
            if (await _skillRepository.AddAsync(skill))
            {
                return new ResultModel<Skill>
                {
                    IsSucces = true,
                    Value = skill
                };
            }
            return new ResultModel<Skill>
            {
                IsSucces = false,
                Errors = new List<string> 
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<IEnumerable<Skill>>> GetAllAsync()
        {
            var skills = await _skillRepository.GetAllAsync();
            if (skills.Any())
            {
                return new ResultModel<IEnumerable<Skill>>
                {
                    IsSucces = true,
                    Value = skills
                };
            }
            return new ResultModel<IEnumerable<Skill>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "No skills found!"
                }
            };
        }

        public async Task<ResultModel<Skill>> GetByIdAsync(Guid id)
        {
            var skill = await _skillRepository.GetByIdAsync(id);
            if (skill != null)
            {
                return new ResultModel<Skill>
                {
                    IsSucces = true,
                    Value = skill
                };
            }
            return new ResultModel<Skill>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Skill not found!"
                }
            };
        }

        public async Task<ResultModel<Skill>> UpdateAsync(Guid id, string name)
        {
            var skill = await _skillRepository.GetByIdAsync(id);
            if (skill == null)
            {
                return new ResultModel<Skill>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Skill not found!"
                    }
                };
            }
            skill.Name = name;
            if (await _skillRepository.UpdateAsync(skill))
            {
                return new ResultModel<Skill>
                {
                    IsSucces = true,
                    Value = skill
                };
            }
            return new ResultModel<Skill>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<Skill>> DeleteAsync(Guid id)
        {
            var skill = await _skillRepository.GetByIdAsync(id);
            if (skill == null)
            {
                return new ResultModel<Skill>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Skill not found!"
                    }
                };
            }
            if (await _skillRepository.DeleteAsync(skill))
            {
                return new ResultModel<Skill>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Skill>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }
    }
}
