Console.WriteLine("Log Analyzer...");

var entry = new LogEntry
{
    Timestamp = DateTime.Now,
    Level = "INFO",
    UserId = 123,
    Action = "Login",
    Message = "User Logged in"
};

Console.WriteLine(entry.Message);

LogCreator.Create(
    entry.Timestamp, 
    entry.Level, 
    entry.UserId, 
    entry.Action,
    entry.Message
);