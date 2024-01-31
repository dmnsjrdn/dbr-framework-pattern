using FluentValidation;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemReadByIdQueryValidator : AbstractValidator<OrderItemReadByIdQuery>
    {
        public OrderItemReadByIdQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}