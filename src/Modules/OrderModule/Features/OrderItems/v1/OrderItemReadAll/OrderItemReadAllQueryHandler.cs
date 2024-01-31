using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemReadAllQueryHandler : IRequestHandler<OrderItemReadAllQuery, ResultList<OrderItem>>
    {
        private readonly IFrameworkPatterns<OrderItem> _patterns;

        public OrderItemReadAllQueryHandler(IFrameworkPatterns<OrderItem> patterns)
        {
            _patterns = patterns;
        }

        public async Task<ResultList<OrderItem>> Handle(OrderItemReadAllQuery request, CancellationToken cancellationToken)
        {
            var result = new ResultList<OrderItem>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}