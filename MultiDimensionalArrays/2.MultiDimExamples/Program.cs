using System;
using System.Collections.Generic;

namespace _2.MultiDimExamples
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();
            List<int[,,]> tss = new List<int[,,]>()
            {
                new int[12,31,24]
            };
            //or you could do
            //tss.Add(new int[12, 31, 24]) in years
            //int yearss = 10;
            //change the conditional to year < yearss and thats it.
            for (int year = 0; year < tss.Count; year++)
            {
                for (int month = 0; month < yearss; month++)
                {
                    for (int day = 0; day < tss[year].GetLength(1); day++)
                    {
                        for (int hour = 0; hour < tss[year].GetLength(2); hour++)
                        {
                            if (month >= 0 && month <= 2)
                            {
                                tss[year][month,day,hour] = rng.Next(-10, 15);
                            }
                            else if (month > 2 && month <= 5)
                            {
                                tss[year][month, day, hour] = rng.Next(15, 25);
                            }
                            else if (month > 5 && month <= 8)
                            {
                                tss[year][month, day, hour] = rng.Next(25, 35);
                            }
                            else if (month > 8 && month <= 11)
                            {
                                tss[year][month, day, hour] = rng.Next(0, 25);
                            }
                            Console.WriteLine(year + " " + month + " " + day + " " + hour + " :" + tss[year][month, day, hour]);
                        }
                    }
                }
            }
        }
    }
}
