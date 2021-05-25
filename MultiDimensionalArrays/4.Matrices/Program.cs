using System;

namespace _4.Matrices
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[4, 4];
            int number = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = number;
                    number++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[j,i],3}");
                }
                Console.WriteLine();
            }

            int[,] second = new int[4, 4];
            int num = 1;
            int pair = -1;
            for (int i = 0; i < second.GetLength(0); i++)
            {
                for (int j = 0; j < second.GetLength(1); j++)
                {
                    if(pair == 1)
                    {
                        matrix[i, 3 - j] = num;
                    }
                    else
                    {
                        matrix[i, j] = num;
                    }
                    num++;
                }
                pair *= -1;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }

            int l = 8;
            int[,] third = new int[l, l];
            int startingRow = l-1;
            int startingColumn = 0;
            int currentRow = 0;
            int currentColumn = 0;
            int variable = 1;
            int counter = 0;
            while(variable <= l * l)
            {
                currentColumn = startingColumn + counter;
                currentRow = startingRow + counter;
                third[currentRow,currentColumn] = variable;
                variable++;
                counter++;
                if (startingRow > 0 && currentRow ==l-1)
                {
                    startingRow--;
                    counter = 0;
                }else if(currentColumn == l - 1)
                {
                    startingColumn++;
                    counter = 0;
                }

            }
            for (int i = 0; i < third.GetLength(0); i++)
            {
                for (int j = 0; j < third.GetLength(1); j++)
                {
                    Console.Write($"{third[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
