using System;

class Program
{
    static void Main()
    {
        string player = "Player";
        int killedEnemies = 40;
        int score = 0;
        int bonus = 0;
        int totalScore = 0;
        if(killedEnemies == 100)
        {
            score = 100;
            bonus = (int)(score * .2);
            totalScore = score + bonus;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player} received a score of {score} and a bonus of {bonus} resulting in {totalScore} points");
        }else if(killedEnemies>=75 && killedEnemies <= 99)
        {
            score = killedEnemies;
            bonus = (int)(score * .05);
            totalScore = score + bonus;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{player} received a score of {score} and a bonus of {bonus} resulting in {totalScore} points");
        }
        else if(killedEnemies>=50 && killedEnemies < 75)
        {
            score = killedEnemies;
            bonus = (int)(score * .05);
            totalScore = score + bonus;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{player} received a score of {score} and a bonus of {bonus} resulting in {totalScore} points");
        }
        else if (killedEnemies >=0 && killedEnemies < 50)
        {
            score = killedEnemies;
            totalScore = score + bonus;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{player} you lost the game");
        }
        else
        {
            Console.WriteLine("Invalid amount of killed enemies");
        }
        Console.ResetColor();
    }
}
