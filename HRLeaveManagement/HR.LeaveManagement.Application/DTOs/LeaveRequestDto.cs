namespace HR.LeaveManagemenet.Domain
{
    using HR.LeaveManagement.Application.DTOs;

    public class LeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? ReuestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approbed { get; set; }
        public bool Cancelled { get; set; }
    }
}
