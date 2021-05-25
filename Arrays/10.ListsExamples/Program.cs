using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ListsExamples
{
    class Program
    {
        static void Main()
        {
            //if you want to use some method with a list as an argument
            //you must write it as u declare a list.

            //static void SomeFunction(List<int> listName){
            // }
            //manually add values to the list:

            int[] arrayOfNumbers = { 1, 2, 3, 4, 5 };
            List<int> someNumbers = new List<int>() { 4, 1, 5, 2 };

            List<int> listNumbers = arrayOfNumbers.ToList();
            //keep adding elements...
            //ADD A LIST OR ARRAY TO A LIST.
            someNumbers.AddRange(arrayOfNumbers);

            Console.WriteLine(string.Join(", ", someNumbers));
            //int[] listAsArray = someNumbers.ToArray();


            List<string> food = new List<string>();
            List<string> vegetables = new List<string>() { "Cucumber", "cabagge" };
            List<string> fruits = new List<string>() { "Cherry", "Strawberry", "Blueberry" };

            food = Adding(new List<string[]>() { vegetables.ToArray(), fruits.ToArray()});

            foreach (var item in food)
            {
                Console.WriteLine(item);
            }

            //SECOND VERSION:

            List<string[]> foodV2 = new List<string[]>() { vegetables.ToArray(), fruits.ToArray() };

            foreach (var stringArray in foodV2)
            {
                foreach (var item in stringArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static List<string> Adding(List<string[]> listOfStringArrays)
        {
            List<string> concatenatedList = new List<string>();

            foreach (var item in listOfStringArrays)
            {
                concatenatedList.AddRange(item);
            }
            return concatenatedList;
        }
    }
}
