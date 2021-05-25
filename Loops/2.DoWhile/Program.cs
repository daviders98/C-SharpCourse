using System;


class Program
{
    static void Main()
    {
        int first = 4;
        int second = 10;

        while (first<=second)
        {
            Console.WriteLine(first);
            first++;
        }

        do
        {
            Console.WriteLine(first);
            first++;
        } while (first <= second);

        //THE DO WHILE CHECKS THE CONDITION AFTER THE FIRST ITERATION.
    }
}
