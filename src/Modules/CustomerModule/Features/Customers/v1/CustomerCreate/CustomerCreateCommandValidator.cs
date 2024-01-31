using FluentValidation;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerCreateCommandValidator : AbstractValidator<CustomerCreateCommand>
    {
        public CustomerCreateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}