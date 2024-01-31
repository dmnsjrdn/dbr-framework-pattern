using CustomerModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerDeleteCommand : IRequest<Result<Customer>>
    {
        public Customer Model { get; set; }
    }
}