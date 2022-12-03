namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto : ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string? ReuestComments { get; set; }
    }
}
