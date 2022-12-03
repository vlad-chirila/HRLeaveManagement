namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
    using MediatR;

    public class CreateLeaveAllocationCommandRequest : IRequest<int>
    {
        public CreateLeaveAllocationDto? LeaveAllocationDto { get; set; }
    }
}
