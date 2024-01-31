using FluentValidation;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemDeleteCommandValidator : AbstractValidator<OrderItemDeleteCommand>
    {
        public OrderItemDeleteCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}