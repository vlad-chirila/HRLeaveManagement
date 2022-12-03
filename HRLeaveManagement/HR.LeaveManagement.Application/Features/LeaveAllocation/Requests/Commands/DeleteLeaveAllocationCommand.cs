namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Commands
{
    using MediatR;

    public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
