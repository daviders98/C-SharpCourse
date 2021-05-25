using System;

namespace _2.OutputtingArrays
{
    class Program
    {
        static void Main()
        {
            string[] beverages = { "coffee", "cola", "water", "whisky", "milkshake" };
            Console.WriteLine(string.Join(", ",beverages));

            Random rng = new Random();
            float[] temperatures = new float[35];
            float min = 25.0f;
            float max = 50.0f;

            string acc1 = " ";
            string acc2 = " ";
            string acc3 = " ";
            string acc4 = " ";
            Console.Clear();
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = min + (max - min) * (float)rng.NextDouble();

                if(temperatures[i]>=25 && temperatures[i] <= 30)
                {
                    acc1 += " " + temperatures[i];
                }else if(temperatures[i]>30 && temperatures[i] <= 35)
                {
                    acc2 += " " + temperatures[i];
                }else if(temperatures[i]>35 && temperatures[i] <= 40)
                {
                    acc3 += " " + temperatures[i];
                }
                else
                {
                    acc4 += " " + temperatures[i];
                }
                
            }
            Console.WriteLine("Range from 25 to 30");
            Console.WriteLine(acc1);
            Console.WriteLine("Range from 30 to 35");
            Console.WriteLine(acc2);
            Console.WriteLine("Range from 35 to 40");
            Console.WriteLine(acc3);
            Console.WriteLine("Out of bounds");
            Console.WriteLine(acc4);
        }
    }
}
