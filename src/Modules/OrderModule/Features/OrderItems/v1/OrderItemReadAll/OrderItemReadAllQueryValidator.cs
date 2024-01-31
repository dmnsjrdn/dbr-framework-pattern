using FluentValidation;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemReadAllQueryValidator : AbstractValidator<OrderItemReadAllQuery>
    {
        public OrderItemReadAllQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}