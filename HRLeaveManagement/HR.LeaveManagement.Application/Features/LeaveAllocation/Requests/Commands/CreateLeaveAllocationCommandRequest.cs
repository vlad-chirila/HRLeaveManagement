namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;

    public class CreateLeaveAllocationCommandRequest : IRequest<int>
    {
        public LeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
