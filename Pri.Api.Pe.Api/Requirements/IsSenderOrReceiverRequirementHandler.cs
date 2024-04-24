using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsSenderOrReceiverRequirementHandler : AuthorizationHandler<IsSenderOrReceiverRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IsSenderOrReceiverRequirementHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsSenderOrReceiverRequirement requirement)
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

            var senderId = Guid.Parse(routeData?.Values["id1"]?.ToString());
            var receiverId = Guid.Parse(routeData?.Values["id2"]?.ToString());

            if (userId == senderId || userId == receiverId)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
}
