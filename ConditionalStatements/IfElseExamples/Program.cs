using System;

class Program
{
    static void Main()
    {
        //write an expression that determines if a given integer is odd or even.
        //output the result on a console.
        int givenInteger = Convert.ToInt32(Console.ReadLine());

        string result = givenInteger % 2 == 0 ? "even" : "odd";
        Console.WriteLine(result);

        //write a boolean expression that checks if an integer can be divided by
        //2,3 and 4 at the same time without remainder.
        if(givenInteger%2==0 && givenInteger%3==0 && givenInteger % 4 == 0)
        {
            Console.WriteLine("YEEES");
        }
        else
        {
            Console.WriteLine("NOOOO");
        }

        //write an expression to check if 3rd digit is 3.
        string checkThis = Console.ReadLine();
        if (checkThis[checkThis.Length-3] == '3')
        {
            Console.WriteLine("THIS IS 3 IN 3RD");
        }
        else
        {
            Console.WriteLine("NOT A 3 BRO");
        }

        //write an if statement that exchanges the values of 2 numbers if the first
        //is bigger than the second.
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());

        int temp = 0;
        if(first > second)
        {
            temp = first;
            first = second;
            second = temp;
        }
        else
        {
            Console.WriteLine("no exchanges made");
        }
        Console.WriteLine(first+" "+second+" "+temp);
    }
}

