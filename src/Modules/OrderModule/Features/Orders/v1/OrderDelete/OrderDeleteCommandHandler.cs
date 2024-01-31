using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderDeleteCommandHandler : IRequestHandler<OrderDeleteCommand, Result<Order>>
    {
        private readonly IFrameworkPatterns<Order> _patterns;

        public OrderDeleteCommandHandler(IFrameworkPatterns<Order> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Order>> Handle(OrderDeleteCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Order>();
            
            // TODO: logic or call the _patterns framework
            await _patterns.CanRemoveAsync(request.Model.UniqueId);
            await _patterns.RemoveAsync(request.Model.UniqueId);

            return result;
        }
    }
}