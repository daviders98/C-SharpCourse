using System;

class Program
{
    static void Main()
    {
        //7 digit precision
        float example = 3.14952921842181f;
        Console.WriteLine(example);
        float area = 3.14f * 5 * 5;

        float fmin = float.MinValue;
        float fmax = float.MaxValue;
        Console.WriteLine(fmin.ToString("f")+" "+fmax.ToString("f"));

        double doublemin = double.MinValue;
        double doublemax = double.MaxValue;
        Console.WriteLine(doublemin.ToString("f")+" "+doublemax.ToString("f"));
        double doublesuffix = 21.42111d;
        //16 digit precision

        decimal decimin = decimal.MinValue;
        decimal decimax = decimal.MaxValue;
        Console.WriteLine(decimin.ToString("f")+" "+decimax.ToString("f"));
        decimal decifix = 2141.12421m;
        //28 - 29 digit precision
    }
}
