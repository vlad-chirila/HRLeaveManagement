﻿namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Handlers.Queries
{
    using AutoMapper;
    using HR.LeaveManagement.Application.DTOs;
    using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries;
    using HR.LeaveManagement.Application.Persistance.Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveAllocationRepository;

        public GetLeaveAllocationListRequestHandler(IMapper mapper, ILeaveRequestRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocation);
        }
    }
}
