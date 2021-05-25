using System;

namespace _4.ReversingDelete
{
    class Program
    {
        static void Main()
        {
            string[] fruits = { "orange", "pineapple", "apple", "pear", "lemon", "cherry" };

            //Uno(ref fruits);
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}
            ReverseSectionOfArray(ref fruits, 2, 3);
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
        static void Uno(ref string[] toberev)
        {
            string[] tobias = new string[toberev.Length];
            int cont = 0;
            for (int i = toberev.Length-1; i >= 0; i--)
            {
                tobias[cont] = toberev[i];
                cont++;
            }
            for (int i = 0; i < toberev.Length; i++)
            {
                toberev[i] = tobias[i];
            }
        }
        static void ReverseSectionOfArray(ref string[] toberev, int index, int quantity)
        {
            string[] pivot = new string[toberev.Length];
            int cont = index;
            for (int i = 0; i < toberev.Length; i++)
            {
                pivot[i] = toberev[i];
            }
            for (int i = index; i < index + quantity; i++)
            {
                pivot[cont] = toberev[index + quantity - i + 1];
                cont++;
            }
            for (int i = 0; i < toberev.Length; i++)
            {
                toberev[i] = pivot[i];
            }
        }
        
    }
}
