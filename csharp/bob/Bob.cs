using System;

public static class Bob
{
    public static string Response(string statement)
    {
        var yelling = statement.ToUpper() == statement && statement.ToLower() != statement;
        var question = statement.TrimEnd().EndsWith("?");
        var empty = string.IsNullOrWhiteSpace(statement);

        //Feels like Excel
        return empty ? "Fine. Be that way!" :
            question && yelling ? "Calm down, I know what I'm doing!" :
            yelling ? "Whoa, chill out!" :
            question ? "Sure." : "Whatever.";
    }
}