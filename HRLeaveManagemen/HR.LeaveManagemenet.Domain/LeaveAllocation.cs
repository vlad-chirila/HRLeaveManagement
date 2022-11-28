﻿namespace HR.LeaveManagemenet.Domain
{
    using HR.LeaveManagemenet.Domain.Common;

    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
