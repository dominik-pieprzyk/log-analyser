public class LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Level { get; set; }
    public int? UserId { get; set; }
    public string Action { get; set; }
    public string Message{ get; set; }
}