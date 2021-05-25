using System;
using System.Collections.Generic;

namespace _9.ListsIntro
{
    class Program
    {
        static void Main()
        {
            //declare the list.
            List<int> ourFirstList = new List<int>();

            //SIZE IS DYNAMIC
            //U dont need to specify the number of elements that are in the list.

            //add elements to the list.
            ourFirstList.Add(4);

            //after you have added elements to the list, you can access or change them
            Console.WriteLine(ourFirstList[0]);
            //remove an element
            ourFirstList.Remove(4);
            ourFirstList.Add(1);
            //remove at a specified index
            ourFirstList.RemoveAt(0);
            Console.WriteLine(ourFirstList.Count);

            Random rng = new Random();

            int[] array = new int[rng.Next(50, 100)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 10);
            }
            List<int> theList = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >=5 && array[i] <=10)
                {
                    theList.Add(array[i]);
                }
            }
            Console.WriteLine(string.Join(", ",array));
            Console.WriteLine(string.Join(", ",theList));
        }
    }
}
