using GraphQLCustomers.Data;
using GraphQLCustomers.GraphQL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CanSeeSalary", policy =>
    {
        policy.Requirements.Add(new RoleRequirement());
    });
});

builder.Services.AddSingleton<IAuthorizationHandler, RoleAuthHandler>();


builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    .AddQueryType<Query>()
    .AddType<CustomerType>()
    .AddProjections()
    .AddFiltering();

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    var identity = new ClaimsIdentity(new[]
//    {
//        new Claim(ClaimTypes.Name, "oguz"),
//        new Claim(ClaimTypes.Role, "Admin2"), // veya "User"
//    }, "test");

//    context.User = new ClaimsPrincipal(identity);

//    await next();
//});

app.MapGraphQL();
app.Run();
