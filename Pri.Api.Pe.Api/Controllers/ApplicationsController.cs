﻿using Microsoft.AspNetCore.Authorization;
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

        private IActionResult HandleError(IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                ModelState.AddModelError("", error);
            }
            return BadRequest(ModelState.Values);
        }

        [HttpPost]
        [Authorize(Policy = "Employee")]
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
                    Salary = result.Value.Salary,
                    ApplicationStatus = result.Value.Status.Name
                });
            }
            return HandleError(result.Errors);
        }

        [HttpGet("job/{jobId}")]
        [Authorize(Policy = "Employer")]
        public async Task<IActionResult> GetAllByJob(Guid jobId)
        {
            var result = await _applicationService.GetAllByJobAsync(jobId);
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(a => new ApplicationResponseDto
                {
                    Id = a.Id,
                    JobId = a.JobId,
                    CandidateId = a.CandidateId,
                    CandidateName = a.Candidate.UserName,
                    Salary = a.Salary,
                    ApplicationStatus = a.Status.Name
                }));
            }
            return HandleError(result.Errors);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Employee")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _applicationService.DeleteAsync(id);
            if (result.IsSucces)
            {
                return Ok("Application removed!");
            }
            return HandleError(result.Errors);
        }

        [HttpGet("candidate/{candidateId}")]
        [Authorize(Policy = "Employee")]
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
                    Salary = a.Salary,
                    ApplicationStatus = a.Status.Name
                }));
            }
            return HandleError(result.Errors);
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
                    CandidateName = result.Value.Candidate.UserName,
                    Salary = result.Value.Salary,
                    ApplicationStatus = result.Value.Status.Name
                });
            }
            return HandleError(result.Errors);
        }

        [HttpPut("{id}")]
        [Authorize(Policy = "Employee")]
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
                    Salary = result.Value.Salary,
                    ApplicationStatus = result.Value.Status.Name
                });
            }
            return HandleError(result.Errors);
        }

        [HttpGet("statuses")]
        public async Task<IActionResult> GetAllStatuses()
        {
            var result = await _applicationService.GetAllStatusesAsync();
            if (result.IsSucces)
            {
                return Ok(result.Value.Select(s => new ApplicationStatusDto
                {
                    Id = s.Id,
                    Name = s.Name
                }));
            }
            return HandleError(result.Errors);
        }

        [HttpPut("{id}/status")]
        [Authorize(Policy = "Employer")]
        public async Task<IActionResult> HandleApplication(Guid id, ApplicationStatusDto applicationStatusDto)
        {
            var entity = await _applicationService.MapDtoToEntity(applicationStatusDto.Id);
            var result = await _applicationService.HandleApplication(id, entity);
            if (result.IsSucces)
            {
                return Ok(new HandleStatusDto
                {
                    Job = result.Value.Job.Name,
                    JobId = result.Value.Job.Id,
                    Status = result.Value.Status.Name
                });
            }
            return HandleError(result.Errors);
        }
    }
}
