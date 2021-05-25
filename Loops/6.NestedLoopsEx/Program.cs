using System;

namespace _6.NestedLoopsEx
{
    class Program
    {
        static void Main()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int daysInMonth = 31;
            int dayOfWeek = 0;
            for (int CurrentMonth = 0; CurrentMonth < months.Length; CurrentMonth++)
            {
                Console.WriteLine($"Month:{months[CurrentMonth]}");
                for (int currentDay = 1; currentDay <= daysInMonth; currentDay++)
                {
                    Console.WriteLine(" "+currentDay+days[dayOfWeek]);

                    dayOfWeek++;

                    if (dayOfWeek == 7)
                    {
                        dayOfWeek = 0;
                    }
                    if ((CurrentMonth==1 && currentDay==28)||
                        ((CurrentMonth==3 || CurrentMonth==5||CurrentMonth==8 ||CurrentMonth==10)&&currentDay==30))
                    {
                        break;
                    }
                }
            }
            
        }
    }
}
