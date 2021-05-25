using System;

namespace _2.ReturnMethods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Addition(1,1));
            int fi = Convert.ToInt32(Console.ReadLine());
            int se = Convert.ToInt32(Console.ReadLine());
            int th = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arraySorter(fi,se,th).Length; i++)
            {
                Console.WriteLine(arraySorter(fi,se,th)[i]);
            }
            
        }

        static int Addition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int[] arraySorter(int first,int second, int third)
        {
            int[] arra = new int[3];
            int place1 = 0;
            int place2 = 0;
            int place3 = 0;
            if (first > second && first > third)
            {
                place1 = first;
                if (second > third)
                {
                    place2 = second;
                    place3 = third;
                }
                else
                {
                    place2 = third;
                    place3 = second;
                }
            }
            else if (first < second && first > third)
            {
                place2 = first;
                place1 = second;
                place3 = third;
            }
            else if (first < second && first < third)
            {
                place3 = first;
                if (second < third)
                {
                    place1 = third;
                    place2 = second;
                }
                else
                {
                    place1 = second;
                    place2 = third;
                }
            }
            else
            {
                place1 = third;
                place2 = first;
                place3 = second;
            }
            arra[0] = place3;
            arra[1] = place2;
            arra[2] = place1;
            return arra;
        }
    }
}
