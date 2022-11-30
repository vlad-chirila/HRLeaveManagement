namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagement.Application.DTOs;

    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocationDto>
    {
        public Task<LeaveAllocationDto> GetLeaveAllocationWithDetails(int Id);
        public Task<LeaveAllocationDto> GetLeaveAllocationsWithDetails();
    }
}
