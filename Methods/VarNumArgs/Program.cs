using System;

namespace VarNumArgs
{
    class Program
    {
        static void Main()
        {
            //1. The parameters must be of the same type.
            //2. The variable parameters should be the last thing as an argument.
            //3. You should use they keyword params
            //4. This should be stored in an array, which will be used later with given name.

            int numberOne = 1;
            int numberTwo = 2;
            int numberZero = 0;
            Console.WriteLine(Sum(2,4,1,2));
            Console.WriteLine("{0} {1} {2} ",numberOne,numberTwo,numberZero);
            Write("{0} {1} {2}", 2, 1,5);
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static void Write(string text, params int[] variables)
        {
            string ret = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]=='{' && text[i + 2] == '}')
                {
                    ret += variables[int.Parse(text[i + 1].ToString())];
                    i += 2;
                }
                else
                {
                    ret += text[i];
                }
            }
            Console.WriteLine(ret);
        }
    }
}
