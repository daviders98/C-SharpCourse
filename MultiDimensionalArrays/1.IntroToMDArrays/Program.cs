using System;
using System.Collections.Generic;

namespace _1.IntroToMDArrays
{
    class Program
    {
        static void Main()
        {
            //declaring a 2 dimensional array.
            //first row of values 
            int[,] temperatures =
                {
                    { 35, 36, 29, 30, 33, 29, 28, 29, 30, 35 },
                    {35, 36, 29, 30, 33, 29, 28, 29, 30, 35 }
            };

            int[,] temps = new int[31, 24];

            temps[4, 10] = 30;
            Console.WriteLine(temps[4, 10]);
            //first dimension lenght, it goes by index.
            Console.WriteLine(temperatures.GetLength(0));

            Random rng = new Random();

            int[,,,] tss = new int[3, 12, 31, 24];

            for (int year = 0; year < tss.GetLength(0); year++)
            {
                for (int month = 0; month < tss.GetLength(1); month++)
                {
                    for (int day = 0; day < tss.GetLength(2); day++)
                    {
                        for (int hour = 0; hour < tss.GetLength(3); hour++)
                        {
                            if(month>=0 && month <= 2)
                            {
                                tss[year, month, day, hour] = rng.Next(-10, 15);
                            }else if(month>2 && month <= 5)
                            {
                                tss[year, month, day, hour] = rng.Next(15, 25);
                            }
                            else if(month>5 && month <= 8)
                            {
                                tss[year, month, day, hour] = rng.Next(25, 35);
                            }
                            else if(month>8 && month <= 11)
                            {
                                tss[year, month, day, hour] = rng.Next(0, 25);
                            }
                            Console.WriteLine(year+" "+month+" "+day+" "+hour+" :"+tss[year,month,day,hour]);
                        }
                    }
                }
            }
        }
    }
}
