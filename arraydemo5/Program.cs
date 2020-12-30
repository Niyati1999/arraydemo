using System;

namespace arraydemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] arr = new int[2, 3] { { 100, 200, 300 }, { 4, 5, 6 } };
            /*Console.WriteLine("0,0 position contains = " + arr[0, 0]);
            Console.WriteLine("0,1 position contains = " + arr[0, 1]);
            Console.WriteLine("0,2 position contains = " + arr[0, 2]);
            Console.WriteLine("1,0 position contains = " + arr[1, 0]);*/
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
            int r = arr.Rank;
            Console.WriteLine($"rank is {r}");
            int l = arr.GetLength(1);
            Console.WriteLine($"Length is {l}");
            int l1 = arr.GetLength(0);
            Console.WriteLine($"length for 0 is {l1}");
        }
    }
}
