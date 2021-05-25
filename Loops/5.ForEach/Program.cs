using System;


class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        //NO CONTROL OVER INDEXER, ALL OF THE ARRAY AND NO CONDITION TO BE DONE.

        //NESTED LOOPS
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"index[{i}][{j}]");
            }
            Console.WriteLine();
        }
    }
}

