using CustomerModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerDeleteCommandHandler : IRequestHandler<CustomerDeleteCommand, Result<Customer>>
    {
        private readonly IFrameworkPatterns<Customer> _patterns;

        public CustomerDeleteCommandHandler(IFrameworkPatterns<Customer> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Customer>> Handle(CustomerDeleteCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Customer>();
            
            // TODO: logic or call the _patterns framework
            await _patterns.CanRemoveAsync(request.Model.UniqueId);
            await _patterns.RemoveAsync(request.Model.UniqueId);

            return result;
        }
    }
}