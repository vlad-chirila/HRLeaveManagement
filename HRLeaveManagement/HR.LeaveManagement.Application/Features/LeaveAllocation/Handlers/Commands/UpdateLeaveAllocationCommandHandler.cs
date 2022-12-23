namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    using AutoMapper;
    using HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
    using HR.LeaveManagement.Application.Exceptions;
    using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands;
    using HR.LeaveManagement.Application.Contracts.Persistence;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository _leaveTypeRepository,
            IMapper mapper)
        {
            this._leaveAllocationRepository = leaveAllocationRepository;
            this._leaveTypeRepository = _leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveAllocationDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveAllocationDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveAllocation = _leaveAllocationRepository.Get(request.LeaveAllocationDto.Id);

            _ = _mapper.Map(request.LeaveAllocationDto, leaveAllocation);

            await _leaveAllocationRepository.Update(leaveAllocation.Result);

            return Unit.Value;
        }
    }
}
