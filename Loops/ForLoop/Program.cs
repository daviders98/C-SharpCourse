using System;


class Program
{
    static void Main()
    {
        int number = 1;

        while (number<=10)
        {
            Console.WriteLine(number);
            number++;
        }

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //DECLARING AN INTEGER ARRAY
        int[] intArray = { 2, 3, 4, 1, 2, 5, 1, -1 };
        //Declaring an integer array with 100 elements.
        int[] integerArr = new int[100];

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
    }
}

