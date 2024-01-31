using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderCreateItemCommandHandler : IRequestHandler<OrderItemCreateCommand, Result<OrderItem>>
    {
        private readonly IFrameworkPatterns<OrderItem> _patterns;

        public OrderCreateItemCommandHandler(IFrameworkPatterns<OrderItem> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<OrderItem>> Handle(OrderItemCreateCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<OrderItem>();
            
            // TODO: logic or call the _patterns framework
            await _patterns.CanSaveAsync(request.Model);
            await _patterns.GetValidAsync(request.Model);
            await _patterns.SaveAsync(request.Model);

            return result;
        }
    }
}