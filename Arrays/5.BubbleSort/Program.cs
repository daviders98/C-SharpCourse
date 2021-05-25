using System;

namespace _5.BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 5, 7, 4, 3, 6 };
            Sort(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        static void Sort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i; j++)
                {
                    if (j < arr.Length - i - 1)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    
                }
            }

        }
    }
}
