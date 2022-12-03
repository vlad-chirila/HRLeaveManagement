namespace HR.LeaveManagement.Application.Features.LeaveRequest.Handlers.Commands
{
    using AutoMapper;
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.Exceptions;
    using HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Commands;
    using HR.LeaveManagement.Application.Features.LeaveRequest.Validators;
    using HR.LeaveManagement.Application.Persistance.Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository _leaveTypeRepository,
            IMapper mapper)
        {
            this._leaveRequestRepository = leaveRequestRepository;
            this._leaveTypeRepository = _leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if(validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);

            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            return leaveRequest.Id;
        } 
    }
}
