using System;

class Program
{
    static void Main()
    {
        int chosenFruit = 0;
        int choice = 0;
        bool newChoice = false;
        string[] fruits = new string[10];
        fruits[0]= "Orange";
        fruits[1] = "Lemon";
        while (!newChoice)
        {
            Console.Write("1. Add new item." +
                "\n2. Edit item." +
                "\n3. Remove item." +
                "\n4. View all items." +
                "\n5. Exit." +
                "\nYour choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < fruits.Length; i++)
                    {
                        if (fruits[i]== null)
                        {
                            Console.WriteLine("Please add a new fruit:");
                            fruits[i] = Console.ReadLine();
                            break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Which fruit do you want to change(1-10)?");
                    chosenFruit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new edited fruit: ");
                    fruits[chosenFruit - 1] = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Which fruit do you want to remove?");
                    chosenFruit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{fruits[chosenFruit-1]} was removed.");
                    fruits[chosenFruit-1] = null;

                    int tempIndex = 0;
                    string[] tempo = new string[fruits.Length];
                    for (int i = 0; i < fruits.Length; i++)
                    {
                        if (fruits[i] != null)
                        {
                            tempo[tempIndex] = fruits[i];
                            tempIndex++;
                        }
                    }
                    Array.Copy(tempo, fruits,tempo.Length);
                    break;
                case 4:
                    Console.WriteLine("Current fruits: ");
                    for (int i = 0; i < fruits.Length; i++)
                    {
                        if(fruits[i]!= null)
                        {
                            Console.WriteLine(" "+(i+1)+". "+fruits[i]);
                        }
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    newChoice = true;
                    break;
                default:
                    break;
            }
        }
    }
}