namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    using HR.LeaveManagemenet.Domain;

    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id);
        public Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
