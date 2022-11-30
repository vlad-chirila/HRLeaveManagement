﻿namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    using AutoMapper;
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
    using HR.LeaveManagement.Application.Persistance.Contracts;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);

            leaveType = await _leaveTypeRepository.Create(leaveType);

            return leaveType.Id;
        }
    }
}