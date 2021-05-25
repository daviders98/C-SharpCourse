using System;


class Program
{
    static void Main()
    {
        //Write an expression that checks if a given point (x,y)
        //is within a circle with radius 4 and center (0,0)
        //using sqrt (x^2+y^2)
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        double radius = 4;
        Convert.ToDouble(x);
        Convert.ToDouble(y);
        double distance = Math.Sqrt((x * x) + (y * y));


        if (distance==radius)
        {
            Console.WriteLine("The point is in the border of the circle");
        }else if (distance < radius)
        {
            Console.WriteLine("The point is inside of the circle");
        }
        else
        {
            Console.WriteLine("The point is outside");
        }


    }
}
