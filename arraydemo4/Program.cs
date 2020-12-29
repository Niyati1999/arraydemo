using System;

namespace arraydemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter 5 values to find out sum and average of them:");
            int[] data = new int[5];
            int sum = 0;
            double avg;
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + data[i];
            }
            avg = sum / data.Length;
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("average = " + avg);
        }
    }
}
