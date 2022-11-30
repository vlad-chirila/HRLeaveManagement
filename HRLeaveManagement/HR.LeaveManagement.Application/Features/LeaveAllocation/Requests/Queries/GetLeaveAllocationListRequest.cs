namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    using HR.LeaveManagement.Application.DTOs;
    using MediatR;

    public class GetLeaveAllocationListRequest :IRequest<List<LeaveAllocationDto>>
    {
    }
}
