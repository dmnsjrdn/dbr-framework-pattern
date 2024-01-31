using FluentValidation;

namespace OrderModule.Features.Orders.v1
{
    public class OrderDeleteCommandValidator : AbstractValidator<OrderDeleteCommand>
    {
        public OrderDeleteCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}