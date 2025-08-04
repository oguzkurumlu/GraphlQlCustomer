using GraphQLCustomers.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLCustomers.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Address> Addresses => Set<Address>();
}
