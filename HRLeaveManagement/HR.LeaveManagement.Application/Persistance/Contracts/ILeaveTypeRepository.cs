namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagement.Application.DTOs;

    public interface ILeaveTypeRepository : IGenericRepository<LeaveTypeDto>
    {
        public Task<LeaveTypeDto> GetLeaveTypeWithDetails(int Id);
        public Task<List<LeaveTypeDto>> GetLeaveTypesWithDetails();
    }
}
