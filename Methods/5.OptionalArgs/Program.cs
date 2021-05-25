using System;

namespace _5.OptionalArgs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Multi(3,5,2));
            Console.WriteLine(Sum(1,4));
        }
        static int Multi(int first, int second, int third = 1)
        {
            return first * second * third;
        }
        static int Sum(int f,int s, int t=0)
        {
            return f + s + t;
        }
    }
}
