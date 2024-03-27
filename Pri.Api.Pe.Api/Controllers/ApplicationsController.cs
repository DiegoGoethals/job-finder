using Microsoft.AspNetCore.Mvc;
using Pri.Api.Pe.Api.Dtos;
using Pri.Api.Pe.Core.Interfaces.Services;

namespace Pri.Api.Pe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : Controller
    {
        private readonly IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        // To do : Check if user is employee role
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationRequestDto applicationRequestDto)
        {
            var result = await _applicationService.CreateAsync(applicationRequestDto.JobId, applicationRequestDto.CandidateId, applicationRequestDto.Salary);
            if (result.IsSucces)
            {
                return CreatedAtAction(nameof(Create), new { result.Value.Id }, new ApplicationResponseDto
                {
                    Id = result.Value.Id,
                    JobId = result.Value.JobId,
                    CandidateId = result.Value.CandidateId,
                    Salary = result.Value.Salary
                });
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        // To do : Check if user is employer role
        [HttpGet("job/{jobId}")]
        public async Task<IActionResult> GetAll(Guid jobId)
        {
            var result = await _applicationService.GetAllByJobAsync(jobId);
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(a => new ApplicationResponseDto
                {
                    Id = a.Id,
                    JobId = a.JobId,
                    CandidateId = a.CandidateId,
                    Salary = a.Salary
                }));
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        // To do : check if user is same user as candidate
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _applicationService.DeleteAsync(id);
            if (result.IsSucces)
            {
                return Ok("Application removed!");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        // To do : Check if user is employee
        [HttpGet("candidate/{candidateId}")]
        public async Task<IActionResult> GetAllByCandidate(Guid candidateId)
        {
            var result = await _applicationService.GetAllByCandidateAsync(candidateId);
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(a => new ApplicationResponseDto
                {
                    Id = a.Id,
                    JobId = a.JobId,
                    CandidateId = a.CandidateId,
                    Salary = a.Salary
                }));
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _applicationService.GetByIdAsync(id);
            if (result.IsSucces)
            {
                return Ok(new ApplicationResponseDto
                {
                    Id = result.Value.Id,
                    JobId = result.Value.JobId,
                    CandidateId = result.Value.CandidateId,
                    Salary = result.Value.Salary
                });
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, ApplicationRequestDto applicationRequestDto)
        {
            var result = await _applicationService.UpdateAsync(id, applicationRequestDto.Salary);
            if (result.IsSucces)
            {
                return Ok(new ApplicationResponseDto
                {
                    Id = result.Value.Id,
                    JobId = result.Value.JobId,
                    CandidateId = result.Value.CandidateId,
                    Salary = result.Value.Salary
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
