namespace HR.LeaveManagement.Application.Responses
{
    /// <summary>
    /// ToDo:
    /// Instead of throw exception this class can be used in handlers
    /// </summary>
    public class BaseCommandResponses
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
