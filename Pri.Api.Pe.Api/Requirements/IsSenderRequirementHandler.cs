using Microsoft.AspNetCore.Authorization;
using Pri.Api.Pe.Core.Interfaces.Services;
using System.Security.Claims;

namespace Pri.Api.Pe.Api.Requirements
{
    public class IsSenderRequirementHandler : AuthorizationHandler<IsSenderRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMessageService _messageService;

        public IsSenderRequirementHandler(IHttpContextAccessor httpContextAccessor, IMessageService messageService)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _messageService = messageService;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsSenderRequirement requirement)
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

            var messageId = Guid.Parse(routeData?.Values["id"]?.ToString());
            var message = await _messageService.GetByIdAsync(messageId);
            var senderId = message.Value.SenderId;

            if (userId == senderId)
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
