using System;

namespace _3.CloneArray
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            //Opcion 1 para copiar todo el array
            int[] array = { 1, 2, 3, 4, 5 };
            int[] secondarray = (int[])array.Clone();
            //opción 2 para copiar una parte del array
            int[] thirdarray = new int[array.Length];
            int[] fourtharray = new int[array.Length];

            Array.Copy(array, thirdarray, 2);
            for (int i = 0; i < thirdarray.Length; i++)
            {
                Console.WriteLine(thirdarray[i]);
            }


            CopyArray(array, fourtharray, 4);
            
            for (int i = 0; i < fourtharray.Length; i++)
            {
                Console.WriteLine(fourtharray[i]);
            }
            array[2] = 100;

            for (int i = 0; i < fourtharray.Length; i++)
            {
                Console.WriteLine(fourtharray[i]);
            }

        }
        static void CopyArray(int[] original, int[] copy, int index)
        {
            for (int i = 0; i < index; i++)
            {
                copy[i] = original[i];
            }
        }
    }
}
