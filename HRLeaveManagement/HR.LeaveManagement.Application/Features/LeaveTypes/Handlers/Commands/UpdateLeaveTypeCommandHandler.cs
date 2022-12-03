namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    using AutoMapper;
    using HR.LeaveManagement.Application.DTOs.LeaveType.Validators;
    using HR.LeaveManagement.Application.Exceptions;
    using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
    using HR.LeaveManagement.Application.Persistance.Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);
           
            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var leaveType = _leaveTypeRepository.Get(request.LeaveTypeDto.Id);

            _ = _mapper.Map(request.LeaveTypeDto, leaveType);

            await _leaveTypeRepository.Update(leaveType.Result);

            return Unit.Value;
        }
    }
}
