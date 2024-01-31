using FluentValidation;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemCreateCommandValidator : AbstractValidator<OrderItemCreateCommand>
    {
        public OrderItemCreateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}