namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Commands
{
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;
    using MediatR;

    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public LeaveRequestDto? LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto? ChangeLeaveRequestApprovalDto { get; set;}
    }
}
