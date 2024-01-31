using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Interfaces;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderCreateCommandHandler : IRequestHandler<OrderCreateCommand, Result<Order>>
    {
        private readonly IFrameworkPatterns<Order> _patterns;

        public OrderCreateCommandHandler(IFrameworkPatterns<Order> patterns)
        {
            _patterns = patterns;
        }

        public async Task<Result<Order>> Handle(OrderCreateCommand request, CancellationToken cancellationToken)
        {
            var result = new Result<Order>();
            
            // TODO: logic or call the _patterns framework
            await _patterns.CanSaveAsync(request.Model);
            await _patterns.GetValidAsync(request.Model);
            await _patterns.SaveAsync(request.Model);

            return result;
        }
    }
}