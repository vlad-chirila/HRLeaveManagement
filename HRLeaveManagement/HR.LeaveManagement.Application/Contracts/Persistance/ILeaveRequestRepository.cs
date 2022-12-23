namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;

    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
    }
}
