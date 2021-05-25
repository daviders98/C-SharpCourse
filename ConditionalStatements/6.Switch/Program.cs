using System;

class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine($"The number is {number}");
                break;
            case 2:
                Console.WriteLine($"The number is {number}");
                break;
            case 3:
                Console.WriteLine($"The number is {number}");
                break;
            case 4:
                Console.WriteLine($"The number is {number}");
                break;
            default:
                Console.WriteLine($"The number {number} doesnt match any available cases.");
                break;
        }
        //SWITCH CASES ARE USED WHEN THERE IS 1 VALUE COMPARED, ELSE IF IS USED WHEN U HAVE MULTIPLE CONDITIONS.
        Console.Write("1. Add new item" +
            "\n2. Edit item" +
            "\n3. Remove item" +
            "\n4. Exit" +
            "\nYour choice: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        switch (number2)
        {
            case 1:
                Console.WriteLine("An item has been added to the list.");
                break;
            case 2:
                Console.WriteLine("An item has been edited");
                break;
            case 3:
                Console.WriteLine("An item has been removed");
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                break;
        }

    }
}
