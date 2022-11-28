﻿namespace HR.LeaveManagemenet.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
