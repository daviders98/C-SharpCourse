using System;


class Program
{
    static void Main()
    {
        // > greater than
        // < less than
        // == equal to
        // >= greater than or equal to
        // <= less than or equal to
        // != not equal or different.

        string first = "KASJFKJFA";
        string second = "aksfkajka";

        string greater;


        Console.WriteLine(first.Length > second.Length);
        //u can't check if a string is greater than other, only different or equal.

        string username = "Frettyboy66";

        bool prof = username.Length > 6 || ((int)username[0] >= 65 && (int)username[0] <= 90);
        Console.WriteLine(prof);
    }
}
