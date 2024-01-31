using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemDeleteCommandHandler : IRequestHandler<OrderItemDeleteCommand, Result<OrderItem>>
    {
        private readonly IFrameworkPatterns<OrderItem> _patterns;

        public OrderItemDeleteCommandHandler(IFrameworkPatterns<OrderItem> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<OrderItem>> Handle(OrderItemDeleteCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<OrderItem>();

            // TODO: logic or call the _patterns framework
            await _patterns.CanRemoveAsync(request.Model.UniqueId);
            await _patterns.RemoveAsync(request.Model.UniqueId);

            return result;
        }
    }
}