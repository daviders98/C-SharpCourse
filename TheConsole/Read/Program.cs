using System;

class Program
{
    static void Main()
    {
        //with this method it returns 1 int as the ASCII table indicates, u can type cast it to a char
        Console.WriteLine("What's ur age?");
        char age = (char)Console.Read();
        Console.WriteLine($"my age is {age}");
    }
}
