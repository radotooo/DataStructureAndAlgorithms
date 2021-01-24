using System;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = Solution.countingValleys(12, "DDUUDDUDUUUD");
            // System.Console.WriteLine(result);
            var nmu = new int[,] {
                    { 1, 1,2, 2},
                    {3 ,3 ,4 ,4}
                 };

            var test2 = new int[,]  {
                 { 1 ,1, 2, 2, 6, 5, 5, 8},
{3, 3, 4, 4, 6, 7, 7, 8}};
            // System.Console.WriteLine(Solution.FillLayer2Matrix());

            var result = Solution.FillLayer2Matrix(test2);
            System.Console.WriteLine(result.Length);

            // System.Console.WriteLine(string.Join(" ", result));
            // System.Console.WriteLine(string.Join(" ,",result[0]));
            int rowLength = result.GetLength(0);
            int colLength = result.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", result[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}

