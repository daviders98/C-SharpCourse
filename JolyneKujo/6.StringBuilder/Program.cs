using System;
using System.Text;


class Program
{
    static void Main()
    {
        DateTime start = DateTime.Now;
            
            
        Concatanator('z', 200000);
        DateTime end = DateTime.Now;
        Console.WriteLine(end-start);

        DateTime startV2 = DateTime.Now;


        StringBuilder test = ConcatanatorSB('z', 20000000);
        DateTime endV2 = DateTime.Now;
        Console.WriteLine(endV2 - startV2);
        string testString = test.ToString();
    }
    static string Concatanator(char thing, int times)
    {
        string accum = string.Empty;

        for (int i = 0; i < times; i++)
        {
            accum += thing;
        }
        return accum;
    }
    static StringBuilder ConcatanatorSB(char cha, int count)
    {
        StringBuilder concatenated = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            concatenated.Append(cha);
        }
        return concatenated;
    }
}
