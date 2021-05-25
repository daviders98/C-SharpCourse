using System;

class Program
{
    static void Main()
    {
        string username = string.Empty;
        string password = string.Empty;

        Console.Write("Input ur username");
        username = Console.ReadLine();
        if (username == "admin")
        {
            Console.WriteLine("Welcome admin, please input ur password");
            password = Console.ReadLine();
            if (password == "password")
            {
                Console.WriteLine("welcome admin, full access granted");
            }
            else
            {
                Console.WriteLine("sorry ur password is incorrect");
            }
        }
        else
        {
            Console.WriteLine("Sorry ur username was incorrect");
        }

        //3 inputs and order them
        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());
        int third = Convert.ToInt32(Console.ReadLine());

        int place1 = 0;
        int place2 = 0;
        int place3 = 0;
        if (first>second && first>third)
        {
            place1 = first;
            if (second > third)
            {
                place2 = second;
                place3 = third;
            }
            else
            {
                place2 = third;
                place3 = second;
            }
        }
        else if(first<second && first>third)
        {
            place2 = first;
            place1 = second;
            place3 = third;
        }else if(first<second && first < third)
        {
            place3 = first;
            if (second < third)
            {
                place1 = third;
                place2 = second;
            }
            else
            {
                place1 = second;
                place2 = third;
            }
        }
        else
        {
            place1 = third;
            place2 = first;
            place3 = second;
        }
        Console.WriteLine(place3+" "+place2+" "+place1);
    }
}
