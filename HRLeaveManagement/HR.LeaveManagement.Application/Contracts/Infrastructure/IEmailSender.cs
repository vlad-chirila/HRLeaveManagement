namespace HR.LeaveManagement.Application.Contracts.Infrastructure
{
    using HR.LeaveManagement.Application.Models;

    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
