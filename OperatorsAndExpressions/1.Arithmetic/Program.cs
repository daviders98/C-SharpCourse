using System;


class Program
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;
        //int/int gives an int, if u want decimals use float or double and typecast both.
        double division = (double)firstNum / (double)secondNum;
        Console.WriteLine(division);
        double fraction = ((3 / 7) + Math.Pow(5, 2)) / (3 + (4 / 3));
        Console.WriteLine(fraction);
        //++, --
        division++;
        Console.WriteLine(division);
        division--;
        Console.WriteLine(division);
    }
}
