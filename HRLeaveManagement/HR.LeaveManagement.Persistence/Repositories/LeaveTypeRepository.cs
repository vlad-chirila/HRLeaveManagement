namespace HR.LeaveManagement.Persistence.Repositories
{
    using HR.LeaveManagement.Domain;
    using HR.LeaveManagement.Application.Contracts.Persistence;

    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrLeaveManagementDbContext _dbContext;
        public LeaveTypeRepository(HrLeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
