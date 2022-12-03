namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    using MediatR;

    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
