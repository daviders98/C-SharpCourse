using System;

namespace _1.Exceptions
{
    class Program
    {
        static void Main()
        {
            //EXCEPTIONS: ERROR THAT CAN HAPPEN.

            try
            {
                //code in here is the thing that u want to know if it works or not.
                int number = Convert.ToInt32(Console.ReadLine());
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number / second);
            }
            catch (DivideByZeroException)
            {
                //THIS WILL BE EXECUTED IF THERE IS AN EXCEPTION, IT WILL NOT BE EXECUTED IF NOT EXCEPTION.
                Console.WriteLine("PLEASE DONT DO THAT");
            }
            //THIS WILL PROCEED ON RUNNING
            Console.WriteLine("AFTER TRY AND CATCH BLOCKS");
        }
    }
}
