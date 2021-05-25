using System;

namespace _2.MultipleExceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number / second);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("PLEASE DONT DO THAT");
            }
            catch (FormatException)
            {
                Console.WriteLine("plz use ints not anything else");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error");
            }




            try
            {
                int[] array = { 1, 2, 3, 4, 5, 0, 0, 6, 7, 8 };
                int number = Convert.ToInt32(Console.ReadLine());
                int calculated = 0;
                for (int i = 0; i < number; i++)
                {
                    calculated = number / array[i];
                    Console.WriteLine(array[i]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("PLZ DO NOT DIVIDE BY ZERO");
                //information about the error
                Console.WriteLine(ex.Message);
                //information about where it happened
                Console.WriteLine(ex.StackTrace);

                string filename = ex.StackTrace.Substring(ex.StackTrace.IndexOf('/')-1,ex.StackTrace.Length-ex.StackTrace.IndexOf('/')+1);
                Console.WriteLine(filename);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("PLZ WRITE AN INTEGER");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("USA UN NUMERO BAJITO BRO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("QUEISISTEPAPS");
            }
        }
    }
}
