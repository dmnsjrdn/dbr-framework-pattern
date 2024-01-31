using FluentValidation;

namespace OrderModule.Features.Orders.v1
{
    public class OrderUpdateCommandValidator : AbstractValidator<OrderUpdateCommand>
    {
        public OrderUpdateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}