using FluentValidation;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerUpdateCommandValidator : AbstractValidator<CustomerUpdateCommand>
    {
        public CustomerUpdateCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}