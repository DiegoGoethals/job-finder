using Microsoft.AspNetCore.Authorization;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsSameCandidateRequirementHandler : AuthorizationHandler<IsSameCandidateRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IApplicationService _applicationService;

        public IsSameCandidateRequirementHandler(IHttpContextAccessor httpContextAccessor, IApplicationService applicationService)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _applicationService = applicationService;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsSameCandidateRequirement requirement)
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

            // Obtain the userId from the requirement
            var applicationId = Guid.Parse(routeData?.Values["id"]?.ToString());
            var application = await _applicationService.GetByIdAsync(applicationId);
            if (application == null)
            {
                context.Fail();
                return;
            }
            var candidateId = application.Value.CandidateId;

            // Check if claimed user's ID matches user's ID
            if (userId == candidateId)
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
