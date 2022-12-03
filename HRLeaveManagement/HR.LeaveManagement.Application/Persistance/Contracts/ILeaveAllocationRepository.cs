namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.DTOs;

    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        public Task<LeaveAllocationDto> GetLeaveAllocationWithDetails(int Id);
        public Task<LeaveAllocationDto> GetLeaveAllocationsWithDetails();
        public Task<LeaveAllocation> Create(LeaveAllocation leaveAllocation);
    }
}
