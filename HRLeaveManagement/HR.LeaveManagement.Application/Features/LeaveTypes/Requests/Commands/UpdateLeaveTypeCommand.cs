namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
