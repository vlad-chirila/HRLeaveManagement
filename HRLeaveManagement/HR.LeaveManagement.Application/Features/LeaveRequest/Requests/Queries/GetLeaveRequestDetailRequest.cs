
namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;
    using MediatR;

    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
