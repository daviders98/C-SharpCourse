using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("The key that was pressed is "+ key.Key);
        //with read u need to press enter to input the character
        //if u want to get the character as it was inputed (lower or upper case) use keychar
        ConsoleKeyInfo keyz = Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("The key that was pressed is " + keyz.KeyChar);
        Console.WriteLine("Modifiers: "+ keyz.Modifiers);
        //u can get the modifiers as well, like alt, ctrl, shift, etc. with modifier property
        //MODIFIERS ARE NOT ORDERED.
    }
}