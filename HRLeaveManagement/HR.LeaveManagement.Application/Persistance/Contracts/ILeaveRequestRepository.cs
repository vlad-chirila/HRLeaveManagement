namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagement.Application.DTOs.LeaveRequest;

    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequestDto>
    {
        public Task<LeaveRequestDto> GetLeaveRequestWithDetails(int Id);
        public Task<List<LeaveRequestDto>> GetLeaveRequestsWithDetails();

    }
}
