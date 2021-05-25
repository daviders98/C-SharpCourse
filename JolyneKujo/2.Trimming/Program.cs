using System;

namespace _2.Trimming
{
    class Program
    {
        static void Main()
        {
            string name = "  Tod  ";
            name = name.Trim();
            Console.WriteLine(name);

            string name2 = "  Vachev";
            name2 = name2.TrimStart();
            Console.WriteLine(name2);

            string lastName = " gdfTodgdf  ";
            lastName = lastName.Trim();
            Console.WriteLine(lastName);

            string[] namesV1 = { "  Tod  ", "  Bob  ", " Maria   ", "Helena   ", " Jacky", "   John    " };
            for (int i = 0; i < namesV1.Length; i++)
            {
                namesV1[i] = namesV1[i].Trim();
            }

            foreach (var item in namesV1)
            {
                Console.WriteLine(item);
            }
            string test = "Tod   ";
            Console.WriteLine(MyTrimming(test));

        }
        static string MyTrimming(string word)
        {
            int index = 0;
            int secondindex = word.Length - 1;
            int i = 0;
            bool leftTrimming = true;
            string accum = "";
            while (leftTrimming)
            {
                if(word[i] != ' ')
                {
                    index = i;
                    leftTrimming = false;
                }
                else if(i==word.Length-1)
                {
                    leftTrimming = false;
                }
                i++;
            }
            bool rightTrimming = true;
            i = word.Length-1;
            while (rightTrimming)
            {
                if(word[i]!=' ')
                {
                    secondindex = i;
                    rightTrimming = false;
                }
                else if (i==0)
                {
                    rightTrimming = false;
                }
                i--;
            }
            for (int j = index; j < secondindex+1; j++)
            {
                accum += word[j];
            }
            return accum;
        }
    }
}
