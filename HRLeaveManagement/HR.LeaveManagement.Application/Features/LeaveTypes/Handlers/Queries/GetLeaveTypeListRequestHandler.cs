namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    using AutoMapper;
    using HR.LeaveManagement.Application.DTOs;
    using HR.LeaveManagement.Application.Features.LeaveTypes.Requests;
    using HR.LeaveManagement.Application.Persistance.Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetLeaveTypesWithDetails();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
