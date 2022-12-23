namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    using HR.LeaveManagemenet.Domain;
    using HR.LeaveManagement.Application.DTOs;

    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    //    public Task<LeaveTypeDto> GetLeaveTypeWithDetails(int Id);
    //    public Task<List<LeaveTypeDto>> GetLeaveTypesWithDetails();
    //    public Task<LeaveType> Create(LeaveType leaveType);
    }
}
