namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
