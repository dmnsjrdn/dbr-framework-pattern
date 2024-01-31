using CustomerModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerReadByIdQueryHandler : IRequestHandler<CustomerReadByIdQuery, Result<Customer>>
    {
        private readonly IFrameworkPatterns<Customer> _patterns;

        public CustomerReadByIdQueryHandler(IFrameworkPatterns<Customer> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Customer>> Handle(CustomerReadByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<Customer>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}