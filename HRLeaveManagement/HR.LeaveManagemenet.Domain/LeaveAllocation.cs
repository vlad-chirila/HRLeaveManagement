namespace HR.LeaveManagement.Domain
{
    using HR.LeaveManagement.Domain.Common;

    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int Period { get; set; }
    }
}
