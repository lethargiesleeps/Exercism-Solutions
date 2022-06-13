using System;
using System.Text;

public static class LogAnalysis
{
    private static string test = "hello".SubstringAfter("hello");

    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string message)
    {
        var strings = str.Split(message);
        return strings[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDel, string lastDel)
    {
        var firstSplit = str.Split(firstDel);
        var secondSplit = firstSplit[1].Split(lastDel);
        return secondSplit[0];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        var strings = str.Split("]: ");
        return strings[1];
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        var strings = str.Split(':');
        var logLevel = new StringBuilder();
        foreach (var c in strings[0])
        {
            if (!c.Equals('[') && !c.Equals(']'))
                logLevel.Append(c);
        }

        return logLevel.ToString();
    }
}

    