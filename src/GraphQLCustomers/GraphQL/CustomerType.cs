using GraphQLCustomers.Models;

namespace GraphQLCustomers.GraphQL
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(c => c.Id);
            descriptor.Field(c => c.Name);
            descriptor.Field(c => c.Email);

            descriptor
                .Field(c => c.Salary)
                .Authorize("CanSeeSalary"); 
        }
    }
}
