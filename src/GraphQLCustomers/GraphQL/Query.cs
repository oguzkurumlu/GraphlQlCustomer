using GraphQLCustomers.Data;
using GraphQLCustomers.Models;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;


namespace GraphQLCustomers.GraphQL;

public class Query
{
    [UseProjection]
    [UseFiltering]
    public IQueryable<Customer> GetCustomers([Service] IDbContextFactory<AppDbContext> dbFactory)
    {
        var db = dbFactory.CreateDbContext();
        return db.Customers;
    }

}
