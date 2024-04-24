using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsEmployeeRequirementHandler : AuthorizationHandler<IsEmployeeRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IsEmployeeRequirementHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsEmployeeRequirement requirement)
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
            var candidateId = Guid.Parse(routeData?.Values["candidateId"]?.ToString());

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
