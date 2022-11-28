namespace HR.LeaveManagemenet.Domain
{
    using HR.LeaveManagement.Application.DTOs;

    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
