using HotChocolate.Authorization;

namespace GraphQLCustomers.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Email { get; set; }

    public string? Salary { get; set; }
}
