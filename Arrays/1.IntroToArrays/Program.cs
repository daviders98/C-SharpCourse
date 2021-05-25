using System;

namespace _1.IntroToArrays
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();

            double[] temperatures = new double[5];
            double minRange = 35.0;
            double maxRange = 40.0;

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = minRange + (maxRange - minRange) * rng.NextDouble();
                Console.WriteLine(temperatures[i]);
            }

            foreach (var item in temperatures)
            {
                //CAN'T MODIFY VALUES FROM ARRAYS, ONLY READ.
            }
        }
    }
}
