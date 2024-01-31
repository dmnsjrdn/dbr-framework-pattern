using FluentValidation;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerReadByIdQueryValidator : AbstractValidator<CustomerReadByIdQuery>
    {
        public CustomerReadByIdQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}