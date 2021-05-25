using System;

namespace _5.Replace
{
    class Program
    {
        static void Main()
        {
            string[] fileDirectory = {
            @"C:\Program Files\Microsoft\Word.exe" ,
            @"C:\Program Files\Microsoft\Excel.exe",
            @"C:\Program Files\Microsoft\PowerPoint.exe"};

            int startIndex = 0;
            int length = 0;
            string filename = "";

            for (int i = 0; i < fileDirectory.Length; i++)
            {
                startIndex = fileDirectory[i].LastIndexOf('\\') + 1;
                length = fileDirectory[i].LastIndexOf('.') - startIndex;
                filename = fileDirectory[i].Substring(startIndex, length);

                fileDirectory[i] = fileDirectory[i].Replace(filename, "nothing");
            }
            

            foreach (var item in fileDirectory)
            {
                Console.WriteLine(item);
            }
            string test = MyReplace("Tod Vachev is the worst at teaching", 18, 5, "best");
            Console.WriteLine(test);
        }
        static string MyReplace(string input, int start, int lenght, string replacement)
        {
            string[] placeholder = input.Split(input.Substring(start,lenght), StringSplitOptions.None);

            string[] another = { placeholder[0], "", placeholder[1] };

            another[1] = replacement;

            return another[0] + another[1] + another[2];
        }
    }
}
