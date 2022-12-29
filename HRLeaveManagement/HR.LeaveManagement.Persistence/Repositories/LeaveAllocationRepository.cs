namespace HR.LeaveManagement.Persistence.Repositories
{
    using HR.LeaveManagement.Domain;
    using HR.LeaveManagement.Application.DTOs;
    using HR.LeaveManagement.Application.Contracts.Persistence;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly HrLeaveManagemenetDbContext _dbContext;
        public LeaveAllocationRepository(HrLeaveManagemenetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
        {
            var leaveAllocations = await _dbContext.LeaveAllocation.Include(x => x.LeaveType).ToListAsync();
            return leaveAllocations;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id)
        {
            var leaveAllocation = await _dbContext.LeaveAllocation.Include(x => x.LeaveType).FirstOrDefaultAsync(y => y.Id == Id);
            return leaveAllocation;
        }
    }
}
