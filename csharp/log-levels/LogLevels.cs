using System;
using System.Text;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] strings = logLine.Split(": "); //split by delimeter ': ' to get two strings in an array
        string returnString = strings[1].Trim(); //Trim any trailing whitespace from expected string
        return returnString;
    }

    public static string LogLevel(string logLine)
    {
        string[] strings = logLine.Split("]:"); //split logLine by delimeter ']:' to get two string in an array
        string level = strings[0]; //the log level is in the first string in the new array
        string returnString = string.Empty;
        for(int i = 1; i < level.Length; i++)
        {
            returnString += level[i]; //Remove the first character using a loop
        }
        return returnString.ToLower(); //log level is expected in lower case
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine); //get the message using method
        string logLevel = " (" + LogLevel(logLine) + ")"; //get the log level, and put it in brackets
        return message + logLevel;
    }
}
