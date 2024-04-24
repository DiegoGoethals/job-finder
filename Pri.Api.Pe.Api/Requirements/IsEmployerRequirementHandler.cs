using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsEmployerRequirementHandler : AuthorizationHandler<IsEmployerRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IJobService _jobService;

        public IsEmployerRequirementHandler(IJobService jobService, IHttpContextAccessor httpContextAccessor)
        {
            _jobService = jobService;
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsEmployerRequirement requirement)
        {
            // Check if the user is authenticated
            if (!context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return;
            }

            // Get the user's ID from claims
            var userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId))
            {
                context.Fail();
                return;
            }

            var routeData = _httpContextAccessor.HttpContext.GetRouteData();
            if (routeData == null)
            {
                context.Fail();
                return;
            }

            // Obtain the jobId from the requirement
            var jobId = routeData?.Values["jobId"]?.ToString();

            // Get the employer ID for the job from the database
            var job = await _jobService.GetByIdAsync(Guid.Parse(jobId));
            if (!job.IsSucces)
            {
                context.Fail();
                return;
            }
            var employerId = job.Value.EmployerId;

            // Check if claimed user's ID matches user's ID
            if (userId == employerId)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
    }
}
