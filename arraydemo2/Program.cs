using System;

namespace arraydemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] marks = new int[] { 1, 3, 5, 7, 9 };

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            
        }
    }
}
