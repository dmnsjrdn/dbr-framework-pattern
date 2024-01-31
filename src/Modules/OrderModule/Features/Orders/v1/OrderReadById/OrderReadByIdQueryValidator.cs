using FluentValidation;

namespace OrderModule.Features.Orders.v1
{
    public class OrderReadByIdQueryValidator : AbstractValidator<OrderReadByIdQuery>
    {
        public OrderReadByIdQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}