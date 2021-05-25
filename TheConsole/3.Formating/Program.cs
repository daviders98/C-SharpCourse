using System;

class Program
{
    static void Main()
    {
        string fruit = "Strawberry";
        string juice = "Juice";
        int dollars = 10000;

        double dollar = 10000.5827192;

        //using variables with placeholders
        Console.WriteLine("{0,15}",fruit);
        Console.WriteLine("{0,15}",juice);

        //not using variables with placeholders
        Console.WriteLine("{0,15}", "Strawberry");
        Console.WriteLine("{0,15}", "Juice");

        //with string interpolation
        Console.WriteLine($"{fruit,15}");
        Console.WriteLine($"{juice,15}");

        //the 15 represents the amount of characters after the last one to put the variable in.
        Console.WriteLine($"{dollars,15:C}");
        Console.WriteLine($"{dollar,15:C5}");
        //the C is a format specifier, the C is a formater for money, the N is for numbers without currency.

        string divisor = new string('=', 22);
        float first = 80.88557f;
        float second = 94.56465f;
        float third = 78.67893f;
        float fourth = 88.66654f;
        float fifth = 88.6466f;
        float sixth = 76.777f;
        float last = 91.85759f;
        float total = first + second + third + fourth + fifth + sixth + last;
        Console.WriteLine("|Protein Intake Week: 1|");
        Console.WriteLine("|" + divisor + "|");
        Console.WriteLine("|" + first + "|");
        Console.WriteLine("|" + second + "|");
        Console.WriteLine("|" + third + "|");
        Console.WriteLine("|" + fourth + "|");
        Console.WriteLine("|" + fifth + "|");
        Console.WriteLine("|" + sixth + "|");
        Console.WriteLine("|" + last + "|");
        Console.WriteLine("|" + divisor + "|");
        Console.WriteLine("|Total" + total + "|");

        Console.WriteLine("|Protein Intake Week: 1|");
        Console.WriteLine("|" + divisor + "|");
        Console.WriteLine($"|{first,22:N2}|");
        Console.WriteLine($"|{second,22:N2}|");
        Console.WriteLine($"|{third,22:N2}|");
        Console.WriteLine($"|{fourth,22:N2}|");
        Console.WriteLine($"|{fifth,22:N2}|");
        Console.WriteLine($"|{sixth,22:N2}|");
        Console.WriteLine($"|{last,22:N2}|");
        Console.WriteLine("|" + divisor + "|");
        Console.WriteLine($"|Total{total,17:N2}|");
    }
}