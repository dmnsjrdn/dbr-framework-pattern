using FluentValidation;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerDeleteCommandValidator : AbstractValidator<CustomerDeleteCommand>
    {
        public CustomerDeleteCommandValidator()
        {
            // TODO: validate the model upfront
        }
    }
}