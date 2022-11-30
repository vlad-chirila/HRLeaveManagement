namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;

    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequestDto>
    {
        public Task<LeaveRequestDto> GetLeaveRequestWithDetails(int Id);
        public Task<LeaveRequestDto> GetLeaveRequestsWithDetails();
        public Task<LeaveRequest> Create(LeaveRequest leaveRequest);
    }
}
