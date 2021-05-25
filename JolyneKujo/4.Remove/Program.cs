using System;

namespace _4.Remove
{
    class Program
    {
        static void Main()
        {

            //string.empty EXTENSION METHODS, Bound to a special data type.
            string Directory = @"C:\Program Files\Microsoft\Word\Word.exe";
            string path = Directory.Remove(Directory.LastIndexOf("\\") + 1);
            Console.WriteLine(path);

            int startingIndex = NthIndexOf(Directory, '\\', 2);
            int length = NthIndexOf(Directory, '\\', 3)-startingIndex;
            string challenge = Directory.Remove(startingIndex, length);

            Console.WriteLine(challenge);
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
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
