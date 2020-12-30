using System;

namespace arraydemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            foreachDemo();
        }
        static void foreachDemo()
        {
            int[] data = new int[5] {1,3,5,7,9};
            foreach(int item in data)
            {
                Console.WriteLine(item);
            }
        }
        static void arraydemo1()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter 5 values to find out sum and average of them:");
            int[] data = new int[5];
            double sum = 0;
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
