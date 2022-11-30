namespace HR.LeaveManagemenet.Domain
{
    using HR.LeaveManagemenet.Domain.Common;

    public class LeaveType : BaseDomainEntity
    {
        public string? Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
