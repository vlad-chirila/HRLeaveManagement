namespace HR.LeaveManagement.Domain
{
    using HR.LeaveManagement.Domain.Common;

    public class LeaveType : BaseDomainEntity
    {
        public string? Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
