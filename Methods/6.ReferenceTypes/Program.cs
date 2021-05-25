using System;

namespace _6.ReferenceTypes
{
    class Program
    {
        static void Main()
        {
            //all data types are value types.
            //ALL ARRAYS, lists AND CLASES ARE REFERENCE TYPES.
            //reference types are not instantiated in the memory when assigned and value types yes.
            int[] array = { 1, 2, 3, 4, 5 };
            int[] secondarray = array;
            array[2] = 10;
            Console.WriteLine(secondarray[2]);
        }
    }
}
