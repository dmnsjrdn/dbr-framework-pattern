using FluentValidation;

namespace OrderModule.Features.Orders.v1
{
    public class OrderReadAllQueryValidator : AbstractValidator<OrderReadAllQuery>
    {
        public OrderReadAllQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}