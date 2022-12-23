namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    using AutoMapper;
    using HR.LeaveManagement.Application.DTOs;
    using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
    using HR.LeaveManagement.Application.Contracts.Persistence;

    public class GetLeaveTypeDetailRequestHandler
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
