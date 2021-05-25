using System;

class Program
{
    static void Main()
    {
        //the way to put numbers in an array
        int[] numbers = { 5, 3, 1 };
        Console.WriteLine(numbers[2]);

        //the way to declare an array size
        int[] nums = new int[10];
        Console.WriteLine(nums[2]);
        numbers[2] = -1;
        Console.WriteLine(numbers[2]);

        //you can have arrays of all data types of variables.
        string[] fruits = { "mango", "watermelon", "banana" };
        Console.WriteLine(fruits[1]);
        //the second indexer on the square brackets is the letter from that element.
        Console.WriteLine(fruits[1][0]);
        //arrays are mutable.
    }
}
