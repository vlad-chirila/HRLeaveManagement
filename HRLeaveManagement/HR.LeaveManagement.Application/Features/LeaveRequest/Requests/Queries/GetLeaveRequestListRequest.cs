
namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;
    using MediatR;

    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {

    }
}
