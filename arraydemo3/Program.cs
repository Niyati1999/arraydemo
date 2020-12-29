using System;

namespace arraydemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] weekDays = new string[] { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
            
        }
    }
}
