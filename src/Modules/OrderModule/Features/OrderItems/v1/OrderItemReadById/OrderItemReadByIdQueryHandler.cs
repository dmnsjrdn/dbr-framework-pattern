using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderReadByIdQueryHandler : IRequestHandler<OrderItemReadByIdQuery, Result<OrderItem>>
    {
        private readonly IFrameworkPatterns<OrderItem> _patterns;

        public OrderReadByIdQueryHandler(IFrameworkPatterns<OrderItem> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<OrderItem>> Handle(OrderItemReadByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<OrderItem>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}