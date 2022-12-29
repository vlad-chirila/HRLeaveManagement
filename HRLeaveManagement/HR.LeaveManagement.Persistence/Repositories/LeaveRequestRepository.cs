namespace HR.LeaveManagement.Persistence.Repositories
{
    using HR.LeaveManagement.Domain;
    using HR.LeaveManagement.Application.Contracts.Persistence;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly HrLeaveManagemenetDbContext _dbContext;
        public LeaveRequestRepository(HrLeaveManagemenetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approbed = ApprovalStatus.Value;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await _dbContext.LeaveRequests.Include(x => x.LeaveType).ToListAsync();
            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _dbContext.LeaveRequests.Include(x => x.LeaveType).FirstOrDefaultAsync(y => y.Id == id);
            return leaveRequest;
        }
    }
}
