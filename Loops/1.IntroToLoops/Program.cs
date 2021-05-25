using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //keyword (condition)
        //{
        //  body
        //}
        int counter = 0;
        while (counter<10)
        {
            Console.WriteLine("We are learning loops");
            counter++;
        }

        int number = 0;
        int min = 20;
        int max = 30;
        bool condition = !(number >= 20 && number <= 30);
        Console.WriteLine("Please input from 20 to 30");
        while (condition)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if(number>=20 && number <= 30)
            {
                condition = false;
            }
            else
            {
                Console.WriteLine($"Please input another number in the range from {min} to {max}");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }

        string warriorName = "Carl";
        string Mage = "Tod";
        Random rng = new Random();
        int warriorDamage = 0;
        int mageDamage = 0;

        int warriorHealth = 100;
        int mageHealth = 100;

        bool gameOver = false;

        while (gameOver == false)
        {
            warriorDamage = rng.Next(1, 10);
            mageDamage = rng.Next(1, 10);

            mageHealth -= mageDamage;
            warriorHealth -= warriorDamage;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{warriorName} inflicted {warriorDamage} damage upon {Mage}. {Mage} has {mageHealth} health remaining");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{Mage} inflicted {mageDamage} damage upon {warriorName}. {warriorName} has {warriorHealth} health remaining");

            if(warriorHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The mage {Mage} won with {mageHealth} health left.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The warrior {warriorName} lost.");
                gameOver = true;
            }else if (mageDamage <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Warrior {warriorName} won with {warriorHealth} health left.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The mage {Mage} lost.");
                gameOver = true;
            }
        }
    }
}

