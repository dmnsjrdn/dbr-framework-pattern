using FluentValidation;

namespace CustomerModule.Features.Customers.v1
{
    public class CustomerReadAllQueryValidator : AbstractValidator<CustomerReadAllQuery>
    {
        public CustomerReadAllQueryValidator()
        {
            // TODO: validate the model upfront
        }
    }
}