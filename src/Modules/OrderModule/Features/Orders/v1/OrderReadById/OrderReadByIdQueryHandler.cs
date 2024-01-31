using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderReadByIdQueryHandler : IRequestHandler<OrderReadByIdQuery, Result<Order>>
    {
        private readonly IFrameworkPatterns<Order> _patterns;

        public OrderReadByIdQueryHandler(IFrameworkPatterns<Order> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Order>> Handle(OrderReadByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new Result<Order>();

            // TODO: logic or call the _patterns framework
            await _patterns.GetValidAsync(request.Model);

            return result;
        }
    }
}