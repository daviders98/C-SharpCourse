using System;

namespace _6.SelectionSort
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            int[] array = { 3000, 5, 3, 100, 4, 1, -1, -500,-2,200};
            int tempVal = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                Console.WriteLine(string.Join(" ,",array));
                tempVal = array[i];
                array[i] = min;
                array[index] = tempVal;
            }
        }
    }
}
