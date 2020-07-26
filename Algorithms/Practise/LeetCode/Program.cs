using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode
{

     class Program
    {
        struct MyStruct
        {
            public int A { get; set; }
            public int B { get; set; }
        }



        static string[,] matrix = new string[3, 3];

        static List<char> path = new List<char>();




        static void Solve(int row, int col, char direction)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }
            path.Add(direction);
            if (IsExit(row, col))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();

                }
            }
            else if (!IsVisited(row, col) && IsFree(row, col))
            {
                matrix[row, col] = "x";
                Solve(row, col + 1, 'R');
                Solve(row + 1, col, 'D');
                Solve(row, col - 1, 'L');

                Solve(row - 1, col, 'U');

                matrix[row, col] = "-";


            }
            path.RemoveAt(path.Count - 1);

        }

        private static bool IsFree(int row, int col)
        {
            if (matrix[row, col] != "*")
            {
                return true;
            }
            return false;
        }

        private static bool IsVisited(int row, int col)
        {
            if (matrix[row, col] == "x")
            {
                return true;
            }
            return false;
        }

        private static bool IsExit(int row, int col)
        {
            if (matrix[row, col] == "e")
            {
                return true;
            }
            return false;
        }

        private static bool IsInBounds(int row, int col)
        {
            if (row >= matrix.GetLength(0) || row < 0)
            {
                return false;
            }

            if (col >= matrix.GetLength(1) || col < 0)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            var Solution = new Solution();

            matrix = new string[3, 3]{
                    {"-","-","-"},
                    {"-","*","-"},
                    {"-","-","e"}
                    };
            Solve(0, 0, 'S');
            //Console.WriteLine(-1+0);
            //Console.WriteLine(Math.Abs(0-1));
            Console.WriteLine(Solution.TitleCase("the quick brown fox"));
            Console.WriteLine(Solution.TitleCase("a clash of KINGS", "a an the of"));
            Console.WriteLine(Solution.TitleCase("THE WIND IN THE WILLOWS", "The In"));


            // Console.WriteLine(12%5);


            //var str = new Solution();

            //Console.WriteLine(str.AlphabetPosition("The sunset sets at twelve o' clock."));



        }

        private static void GG(MyStruct str)
        {
            str.A = 100;
        }
    }

}


