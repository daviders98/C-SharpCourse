using System;

class Program
{
    static void Main()
    {
        //the color changes the things after it.
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A turtle made it to the water.");
        Console.WriteLine("I've collected many things over the years.");
        Console.ResetColor();
        Console.WriteLine("The cycle of life can be cruel.");

        string divisor = new string('=', 22);
        float first = 80.88557f;
        float second = 94.56465f;
        float third = 78.67893f;
        float fourth = 88.66654f;
        float fifth = 88.6466f;
        float sixth = 76.777f;
        float last = 91.85759f;
        float total = first + second + third + fourth + fifth + sixth + last;

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("|" + divisor + "|");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write("Protein Intake Week: 1");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.WriteLine("|" + divisor + "|");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{first,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{second,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{third,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{fourth,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{fifth,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{sixth,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Write($"{last,22:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
        Console.WriteLine("|" + divisor + "|");
        Console.Write($"|");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write($"Total{total,17:N2}");
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("|\n");
    }
}
