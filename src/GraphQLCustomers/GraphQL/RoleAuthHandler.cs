using HotChocolate.Resolvers;
using Microsoft.AspNetCore.Authorization;

namespace GraphQLCustomers.GraphQL
{
    public class RoleAuthHandler : AuthorizationHandler<RoleRequirement>, IAuthorizationHandler
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            RoleRequirement requirement)
        {
            //context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
