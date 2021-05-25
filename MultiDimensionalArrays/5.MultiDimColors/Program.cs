using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace _5.MultiDimColors
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();
            byte[,,] numbers = new byte[3,1080,1920];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(2); k++)
                    {
                        numbers[i, j, k] = (byte)rng.Next();
                    }
                }
            }

            Bitmap bitmapImg = new Bitmap()
        }
    }
}
