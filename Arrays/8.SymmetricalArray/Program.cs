using System;

namespace _8.SymmetricalArray
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5,6,4, 3, 2, 1 };
            int middle = array.Length / 2;
            int[] other = new int[middle+1];
            int counter = 0;

            for (int i = 0; i < (array.Length/2); i++)
            {
                other[i] = array[array.Length-1-i];
                if (other[i] == array[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            if (counter == array.Length / 2)
            {
                Console.WriteLine("This is a symmetrical array");
            }
            bool isSimetrical = true;
            int[] arrayz = { 1, 2, 3, 4, 6, 6, 4, 3, 2, 1 };
            for (int i = 0; i < arrayz.Length/2; i++)
            {
                if (arrayz[i] != arrayz[arrayz.Length-i-1])
                {
                    isSimetrical = false;
                    break;
                }
            }
            Console.WriteLine(isSimetrical);
        }
    }
}
