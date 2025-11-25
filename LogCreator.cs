using System.IO;
using System.Text;

public static class LogCreator
{
    public static void CreateLog(string path)
    {
        File.WriteAllText(path, ""); 
    }
    public static void PopulateLog(
        string path,
        DateTime Timestamp,
        string level,
        int? userids,
        string action,
        string message
    )
    {
        File.AppendAllText(
            path,
            $"{Timestamp},{level},{userids},{action},{message},\n"
        );
    }

    // public static void SetLogSize(
    //     int filesize,
    //     string path,
    //     object log
    // )
    // {
    //     for (int size =0; size<filesize; size++)
    //     {
            
    //     }
    // }
}