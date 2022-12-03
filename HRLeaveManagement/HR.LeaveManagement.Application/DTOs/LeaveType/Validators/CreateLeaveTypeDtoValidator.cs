namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    using FluentValidation;

    public class CreateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropartyName} must not exceed 50 characters.");

            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropartyName} is required.")
                .GreaterThan(0)
                .LessThan(100);
        }
    }
}
