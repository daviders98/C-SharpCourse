using System;

class Program
{
    static void Main()
    {
        ////this works for all cases.
        ///
        //Console.WriteLine("How old r u?");
        //string age = Console.ReadLine();
        //Console.WriteLine($"my age is {age}");

        ////this works only is u know it is an integer 100%.
        ///
        //Console.WriteLine("How old r u?");
        //int agez = int.Parse(Console.ReadLine());
        //Console.WriteLine($"my age is {agez}");

        Console.Write("Input the drive letter: ");
        string drive = Console.ReadLine();
        Console.Write("Input the folder path: ");
        string folder = Console.ReadLine();

        Console.Write("Input the file name: ");
        string file = Console.ReadLine();
        Console.WriteLine($"{drive}:\\{folder}\\{file}.exe");

        //when using the read method, the enter is counted as the next input, so it is stored in the second variable.
        //to not get this is use readline or move the read method last.

    }
}
