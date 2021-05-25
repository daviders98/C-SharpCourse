using System;

class Program
{
    static void Main()
    {
        Console.Write("I am learning a c# programming course");
        //this 2 give the same result.
        Console.Write("I am learning");
        Console.Write("a c# programming");
        Console.Write("course.");
        // \n is a endline
        //the difference between the write and writeline methods is that with the line, it jumps to next line at the end.
        Console.Write("\n1. Add new item\n2. Edit an item\n3. Remove an item\n4. Exit\nYour Choice:\n");
        Console.Write("\n1. Add new item\n" +
            "2. Edit an item\n" +
            "3. Remove an item\n" +
            "4. Exit\n" +
            "Your Choice:\n");
    }
}
