using CustomerModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerReadAllQueryHandler : IRequestHandler<CustomerReadAllQuery, ResultList<Customer>>
    {
        private readonly IFrameworkPatterns<Customer> _patterns;

        public CustomerReadAllQueryHandler(IFrameworkPatterns<Customer> patterns)
        {
            _patterns = patterns;
        }

        public async Task<ResultList<Customer>> Handle(CustomerReadAllQuery request, CancellationToken cancellationToken)
        {
            var result = new ResultList<Customer>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}