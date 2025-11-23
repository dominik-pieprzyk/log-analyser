using System.IO;
using System.Text;

/*

    Also next time push to git, and start tracking the project.   
    
    Plan:
    1. Fix appending multiple lines to a file
    2. Multiple file creation
    3. Push to git
*/

public static class LogCreator
{
    
    public static void Create(
        DateTime Timestamp,
        string level,
        int? userids,
        string action,
        string message
    )
    {
        string row = $"{Timestamp},{level},{userids},{action},{message},";
        File.WriteAllText("sample.CSV", "");
        //int max_file_size = new Random.Next(1,12500);
        for(int itteration=0; itteration<100; itteration++)
        {
            File.AppendAllText("sample.CSV", row + "\n");
        }
    }
}