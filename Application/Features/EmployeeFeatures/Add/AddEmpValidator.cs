using Domain.Entities;
using FluentValidation;

namespace Application.Features.EmployeeFeatures.Add
{
    public sealed class AddEmpValidator:AbstractValidator<Employee>
    {
        public AddEmpValidator() {
            RuleFor(x => x.EmployeeId).NotEmpty().NotNull();
            RuleFor(x => x.CompanyName).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(x => x.VerificationCode).NotEmpty().NotNull().MaximumLength(20);
        }
    }
}
