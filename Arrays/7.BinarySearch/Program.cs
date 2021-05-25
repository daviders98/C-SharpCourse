using System;

namespace _7.BinarySearch
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 7, 10, 100, 150, 300};
            bool Notfound = true;
            Console.WriteLine("Enter the number to look for:");
            int num =Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = array.Length-1;
            int middle = 0;
            while (Notfound)
            {
                middle = (start + end) / 2;
                Console.WriteLine(start + " " + middle + " " + end);
                if (array[middle] == num)
                {
                    Notfound = false;
                }else if(num < array[middle])
                {
                    end = middle-1;
                    middle = (start + end) / 2;
                }
                else
                {
                    start = middle + 1;
                    middle = (start + end) / 2;
                }
            }
            Console.WriteLine($"The number {num} is located in the {middle} index");
        }
    }
}
