using System;

namespace _3.Substring
{
    class Program
    {
        static void Main()
        {
            string Directory = @"C:\Program Files\Microsoft\Word\Word.exe";
            string firstPart = Directory.Substring(32);
            Console.WriteLine(firstPart);
            string secondOverload = Directory.Substring(0, 16);
            Console.WriteLine(secondOverload);
            int startingIndex = 0;
            int length = Directory.IndexOf('s') + 1;
            Console.WriteLine(Directory.Substring(startingIndex,length));

            string extension = "";
            string fileName = "";
            string firstFolder = "";
            string secondFolder = "";

            extension = Directory.Substring(Directory.IndexOf('.'));
            Console.WriteLine(extension);

            fileName = Directory.Substring(Directory.LastIndexOf('\\')+1);
            Console.WriteLine(fileName);

            Console.WriteLine(NthIndexOf(Directory,'d',2));

        }
        static int NthIndexOf(string input, char toFind, int occurance)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == toFind)
                {
                    counter++;
                }
                if (occurance == counter)
                {
                    return i+1;
                }
            }
            return -1;
        }
    }
}
