using System;

namespace _3.OverloadingMethods
{
    class Program
    {
        static void Main()
        {
            PrintNames("David", "Garcia");
            PrintNames("David", "Alexys", "Garcia");
        }
        static void PrintNames(string name, string lastname)
        {
            Console.WriteLine($"My name is {name}, and my last name is {lastname}");
        }
        static void PrintNames(string name, string middlename,string lastname)
        {
            Console.WriteLine($"My name is {name}, my middle name is {middlename}, and my last name is {lastname}");
        }
    }
}
