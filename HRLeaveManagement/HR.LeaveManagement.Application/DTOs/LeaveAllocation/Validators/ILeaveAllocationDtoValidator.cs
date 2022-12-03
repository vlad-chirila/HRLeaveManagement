﻿namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    using FluentValidation;
    using HR.LeaveManagement.Application.Persistance.Contracts;

    public class ILeaveAllocationDtoValidator : AbstractValidator<ILeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public ILeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            RuleFor(p => p.NumberOfDays)
                .GreaterThan(0).WithMessage("{PropertyName} must greater than {ComparisonValue}");

            RuleFor(p => p.Period)
                .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) => 
                {
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                    return !leaveTypeExists;
                })
                .WithMessage("{PropertyName} does not exist.");
            
        }
    }
}
