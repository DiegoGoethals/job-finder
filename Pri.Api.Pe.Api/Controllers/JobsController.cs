using Microsoft.AspNetCore.Mvc;
using Pri.Api.Pe.Api.Dtos;
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

        [HttpPost]
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
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }
    }
}
