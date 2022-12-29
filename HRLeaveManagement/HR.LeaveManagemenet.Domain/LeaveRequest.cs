﻿namespace HR.LeaveManagement.Domain
{
    using HR.LeaveManagement.Domain.Common;

    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public string? ReuestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool Approbed { get; set; }
        public bool Cancelled { get; set; }
    }
}
