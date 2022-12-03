namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public LeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
