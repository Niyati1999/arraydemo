using System;

namespace arraydemo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] marks = new int[3,5];

            double sum;
            double max;
            double avg = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                   marks[i,j] = Convert.ToInt32(Console.ReadLine());
                  
                }
            }
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                max = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (marks[i, j] > max)
                    {
                        max = marks[i, j];
                    }
                    Console.Write(marks[i,j] +"\t");
                    sum = sum + marks[i, j];
                    avg = sum / 5;
                }
                Console.Write($"sum = {sum} \t");
                Console.Write($"Avg = {avg} \t");
                Console.Write($"Max = {max} \t");
                Console.WriteLine();
            }
            int minValue = int.MinValue;
            Console.WriteLine(minValue);
        }

    }
}
