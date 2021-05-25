using System;
using System.IO;

namespace _3.TryCatchFinally
{
    class Program
    {
        static void Main()
        {
            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(Directory.GetCurrentDirectory() + @"\test.txt");
                int numer = Convert.ToInt32(Console.ReadLine());
                int divided = 5 / numer;
                sw.Write(divided);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //this executes regardless if we get an exception or not.
                //if you get an exception in this example, the file remains open. so...
                sw.Close();
            }
            try
            {
                StreamReader sr = File.OpenText(Directory.GetCurrentDirectory() + @"\test.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
             //USE TRY CATCH AND FINALLY WHEN THERE'S A LOT OF EXCEPTIONS TO COVER...
        }
    }
}
