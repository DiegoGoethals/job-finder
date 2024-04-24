using Microsoft.AspNetCore.Authorization;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsReviewerRequirementHandler : AuthorizationHandler<IsReviewerRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IReviewService _reviewService;

        public IsReviewerRequirementHandler(IHttpContextAccessor httpContextAccessor, IReviewService reviewService)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _reviewService = reviewService;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsReviewerRequirement requirement)
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

            var reviewId = Guid.Parse(routeData?.Values["id"]?.ToString());
            var review = await _reviewService.GetByIdAsync(reviewId);
            var reviewerId = review.Value.ReviewerId;

            if (userId == reviewerId)
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
