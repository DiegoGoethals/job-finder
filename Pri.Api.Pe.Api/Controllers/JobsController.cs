using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pri.Api.Pe.Api.Dtos;
using Pri.Api.Pe.Api.Requirements;
using Pri.Api.Pe.Core.Interfaces.Services;

namespace Pri.Api.Pe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        private IActionResult HandleError(IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        // To do : Check if user is employer
        [HttpPost]
        [Authorize(Policy = "Employer")]
        public async Task<IActionResult> Create(JobRequestDto jobRequestDto)
        { 
            var result = await _jobService.CreateAsync(jobRequestDto.Name, jobRequestDto.Description, jobRequestDto.Salary, jobRequestDto.EmployerId, jobRequestDto.Skills);
            if (result.IsSucces)
            {
                return CreatedAtAction(nameof(Create), new { result.Value.Id }, new JobResponseDto
                {
                    Id = result.Value.Id,
                    Name = result.Value.Name,
                    Description = result.Value.Description,
                    Salary = result.Value.Salary,
                    EmployerId = result.Value.EmployerId
                });
            }
            return HandleError(result.Errors);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Employer")]
        [Authorize(Policy = "IsEmployer")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _jobService.DeleteAsync(id);
            if (result.IsSucces)
            {
                return Ok("Job removed!");
            }
            return HandleError(result.Errors);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _jobService.GetAllAsync();
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(job => new JobResponseDto
                {
                    Id = job.Id,
                    Name = job.Name,
                    Description = job.Description,
                    Salary = job.Salary,
                    EmployerId = job.EmployerId
                }));
            }
            return HandleError(result.Errors);
        }

        [HttpGet("skills")]
        public async Task<IActionResult> GetBySkills([FromQuery] IEnumerable<string> skills)
        {
            var result = await _jobService.GetBySkills(skills);
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(job => new JobResponseDto
                {
                    Id = job.Id,
                    Name = job.Name,
                    Description = job.Description,
                    Salary = job.Salary,
                    EmployerId = job.EmployerId
                }));
            }
            return HandleError(result.Errors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _jobService.GetByIdAsync(id);
            if (result.IsSucces)
            {
                return Ok(new JobResponseDto
                {
                    Id = result.Value.Id,
                    Name = result.Value.Name,
                    Description = result.Value.Description,
                    Salary = result.Value.Salary,
                    EmployerId = result.Value.EmployerId
                });
            }
            return HandleError(result.Errors);
        }

        [HttpPut("{id}")]
        [Authorize(Policy = "Employer")]
        [Authorize(Policy = "IsEmployer")]
        public async Task<IActionResult> Update(Guid id, JobRequestDto jobRequestDto)
        {
            var result = await _jobService.UpdateAsync(id, jobRequestDto.Name, jobRequestDto.Description, jobRequestDto.Salary, jobRequestDto.Skills);
            if (result.IsSucces)
            {
                return Ok(new JobResponseDto
                {
                    Id = result.Value.Id,
                    Name = result.Value.Name,
                    Description = result.Value.Description,
                    Salary = result.Value.Salary,
                    EmployerId = result.Value.EmployerId
                });
            }
            return HandleError(result.Errors);
        }
    }
}
