using System;

namespace _7.RefOut
{
    class Program
    {
        static void Main()
        {
            //ref keyword converts a value type to a reference type assigning the value to the one out of the scope
            //of the method.

            //This is usefull when u have multiple arguments, multiple returns or returning another thing.


            int number = 0;
            Console.WriteLine(number);
            IncreaseByOne(ref number);
            Console.WriteLine(number);

            //The out keyword does the same but in order for it to work, it must be assigned some value
            //on the method that is going to be used, it can be declared in the call of the function but
            //the assignment of a value must happen within the method itself.

            //With the Out keyword, it creates a variable of the same scope where its called the function.
            //OUT KEYWORD IS LIKE A RETURN.
            double x = 10;
            CorrectCoordinate(ref x, out double y);
            Console.WriteLine(x+" "+y);

            AreaAndPerimeter(10, 4, out double area, out double perim);
            Console.WriteLine($"{area} is the area, and the perimeter is {perim}");
        }
        static void IncreaseByOne(ref int num)
        {
            num++;
        }
        static void CorrectCoordinate(ref double x, out double y)
        {
            y = 10;
            x *= 10;
            y *= 10;
        }
        static void AreaAndPerimeter(double Base, double Height, out double Area, out double Perimeter)
        {
            Area = Base * Height;
            Perimeter = 2 * (Base + Height);
        }
    }
}
