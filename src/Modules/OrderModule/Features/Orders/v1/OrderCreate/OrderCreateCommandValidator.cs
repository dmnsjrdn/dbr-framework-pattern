using FluentValidation;

namespace OrderModule.Features.Orders.v1
{
    public class OrderCreateCommandValidator : AbstractValidator<OrderCreateCommand>
    {
        public OrderCreateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}