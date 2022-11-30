namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto? LeaveTypeDto { get; set; }
    }
}
