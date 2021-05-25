using System;


class Program
{
    static void Main()
    {
        //ternary condition, if its true the right side is done if not the left side is done.

        //variable = comparison or expression ? true : false;

        //must be same types
        string incomingTemporaryUsername = "ss";
        string username = incomingTemporaryUsername.Length > 6 ? incomingTemporaryUsername : "default_username";
        Console.WriteLine(username);

        ConsoleColor color = incomingTemporaryUsername.Length > 6 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.ForegroundColor = color;
        Console.WriteLine(username);
    }
}
