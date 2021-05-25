using System;
using System.Collections.Generic;

namespace _3.StringMDAChallenge
{
    class Program
    {
        static void Main()
        {
            //to not use this complicated cycle, you can split a string with split function.
            //person = input.Split(new string[]{","},StringSplitOptions.none)

            string accum = "";
            List<string> stored = new List<string>();

            string[,] people = new string[5, 4];

            for (int j = 0; j < people.GetLength(0); j++)
            {
                Console.WriteLine("Please input your information in the following format: \"FirstName,LastName,Age,City\"");
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {

                    if (stored.Count == 3 && i == input.Length - 1)
                    {
                        accum += input[i];
                        stored.Add(accum);
                    }
                    else
                    {
                        if (input[i] != ',')
                        {
                            accum += input[i];
                        }
                        else
                        {
                            stored.Add(accum);
                            accum = "";
                        }
                    }
                }
                
                for (int k = 0; k < stored.Count; k++)
                {
                    people[j, k] = stored[k];
                    
                }
                int x = 0;
                while (stored.Count != 0)
                {
                    stored.RemoveAt(x);
                }
            }
            for (int i = 0; i < people.GetLength(0); i++)
            {
                for (int j = 0; j < people.GetLength(1); j++)
                {
                    Console.Write(people[i,j]+" ");
                }
                Console.Write("\n");
            }




        }
    }
}
