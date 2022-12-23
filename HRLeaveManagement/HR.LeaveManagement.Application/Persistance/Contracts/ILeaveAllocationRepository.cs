namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagemenet.Domain;

    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id);
        public Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
