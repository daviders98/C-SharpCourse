using System;

class Program
{
    static void Main()
    {
        //how to make a separator, python-esque repeater string*number
        string separator = new string('-', 40);
        string fruitJuice = "Strawberries";
        Console.WriteLine(fruitJuice.Contains('r'));
        Console.WriteLine(separator);
        //CASE SENSITIVE.
        Console.WriteLine(fruitJuice.Contains('R'));
        Console.WriteLine(separator);
        //if character exist, then it returns the index where it is.
        Console.WriteLine(fruitJuice.IndexOf("r"));
        Console.WriteLine(separator);
        //if char doesnt exist, then it returns -1
        Console.WriteLine(fruitJuice.IndexOf("m"));
        //if multiple characters, then you get the first index.
        Console.WriteLine(fruitJuice.IndexOf("r"));
        Console.WriteLine(fruitJuice.LastIndexOf("r"));
        Console.WriteLine(fruitJuice.ToLower().Contains("straw"));

        //this can have chars and strings (search for substrings)
    }
}
