using System;


class Program
{
    static void Main()
    {
        //acumuladores
        int firstNum = 5;
        int secondNum = 10;

        firstNum += secondNum;
        Console.WriteLine(firstNum);

        firstNum -= secondNum;
        Console.WriteLine(firstNum);
        firstNum *= secondNum;
        Console.WriteLine(firstNum);
        firstNum /= secondNum;
        Console.WriteLine(firstNum);
        firstNum %= secondNum;
        Console.WriteLine(firstNum);
    }
}

