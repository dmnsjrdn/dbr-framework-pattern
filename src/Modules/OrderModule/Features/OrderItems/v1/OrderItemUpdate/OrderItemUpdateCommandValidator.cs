using FluentValidation;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemUpdateCommandValidator : AbstractValidator<OrderItemUpdateCommand>
    {
        public OrderItemUpdateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}