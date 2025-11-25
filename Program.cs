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

string[] levels = ["INFO", "WARN", "ERROR"];
string[] actions= ["Register", "Login", "Logout", "PasswordReset"];
var messages = new List<string>
{
    "User logged in successfully",
    "User logged out",
    "Stock level low for product 456",
    "Payment gateway timeout",
    "Failed to connect to database"
};
Random rand = new Random(3);
DateTime startdate = new DateTime(2025, 11, 1);
LogCreator.CreateLog("sample.csv");
for (int size=0; size<100; size++)
{
    
    int rndlevel = rand.Next(0,2);
    int rnduserids = rand.Next(0,999);
    int rndactions = rand.Next(0,3);
    int rndmessages = rand.Next(0,4);
    // File.AppendAllText("sample.csv",
    // LogCreator.PopulateLog(
        
    //     $"{startdate.AddDays(1),
    //     {levels[rndlevel],
    //     {rnduserids,
    //     {actions[rndactions],
    //     {messages[rndmessages]
    // );
    // To start from selection as the file is not populated with unique rows
}