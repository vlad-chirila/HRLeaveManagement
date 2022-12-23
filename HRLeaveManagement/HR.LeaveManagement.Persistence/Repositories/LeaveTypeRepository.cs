namespace HR.LeaveManagement.Persistence.Repositories
{
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.Persistance.Contracts;

    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrLeaveManagemenetDbContext _dbContext;
        public LeaveTypeRepository(HrLeaveManagemenetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
