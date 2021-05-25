using System;


class Program
{
    static void Main()
    {
        int number = 4315231;
        Console.WriteLine(number.ToString().Contains("3"));
        Console.WriteLine(number.ToString().IndexOf("3"));
        Console.WriteLine(number.ToString().LastIndexOf("3"));
        string ilearn = "I am learning";
        string nameofcourse = " c# mastercourse";

        string concatenated = ilearn + nameofcourse + 5;
        Console.WriteLine(concatenated);
    }
}
