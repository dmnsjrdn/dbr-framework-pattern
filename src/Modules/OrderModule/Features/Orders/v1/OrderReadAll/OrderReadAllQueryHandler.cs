using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderReadAllQueryHandler : IRequestHandler<OrderReadAllQuery, ResultList<Order>>
    {
        private readonly IFrameworkPatterns<Order> _patterns;

        public OrderReadAllQueryHandler(IFrameworkPatterns<Order> patterns)
        {
            _patterns = patterns;
        }

        public async Task<ResultList<Order>> Handle(OrderReadAllQuery request, CancellationToken cancellationToken)
        {
            var result = new ResultList<Order>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}