using System;

namespace arraydemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] marks = new int[5];
            Console.WriteLine("Enter the marks for 5 subjects");
            for(int i = 0; i<marks.Length ; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine(marks.Length);
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
