
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerRank
{
    public class Solution
    {

        //! Repeated String
        public static long RepeatedString(string s, long n)
        {
            var aCharCountInString = s.Count(x => x == 'a');

            var stringOccurrenceInNum = n / s.Length;
            var leftOverCharsCount = n % s.Length;

            var result = stringOccurrenceInNum * aCharCountInString;
            result += s.Take(Convert.ToInt32(leftOverCharsCount)).Count(x => x == 'a');

            return result;
        }

        public static double RoundBy(double n)
        {
            return Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2;

        }

        public static int[,] FillLayer2Matrix(int[,] matrixLayer1)
        {

            var answer = new int[(2 * 2) + 1, (8 * 2) + 1];
            var matrixLayer2 = new int[2, 8];

            var brickNumber = 0;
            var brickSeparator = -2;

            //fill the second layer with the solution and prepare for the asterix surrounding
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    //check if this is the last column and if it is add a vertical brick
                    if (matrixLayer2[row, col] == 0 && col == 8 - 1)
                    {
                        brickNumber++;
                        matrixLayer2[row, col] = answer[(row * 2) + 1, (col * 2) + 1] = brickNumber;
                        matrixLayer2[row + 1, col] = answer[(row * 2) + 3, (col * 2) + 1] = brickNumber;
                        answer[(row * 2) + 2, (col * 2) + 1] = brickSeparator;

                        //check if brick from secondLayer is laying on brick from firstLayer
                        if (matrixLayer1[row, col] - matrixLayer1[row + 1, col] == 0)
                        {
                            //if it is then no solution is possible
                            // throw new Exception(errorMessage);
                        }
                    }
                    //check if position is free
                    else if (matrixLayer2[row, col] == 0 && col < 8 - 1)
                    {
                        brickNumber++;

                        //check if brick on layer 1 is horizontal
                        if (matrixLayer1[row, col] - matrixLayer1[row, col + 1] == 0)
                        {
                            //if brick is horizontal place a vertical brick on layer2
                            matrixLayer2[row, col] = answer[(row * 2) + 1, (col * 2) + 1] = brickNumber;
                            matrixLayer2[row + 1, col] = answer[(row * 2) + 3, (col * 2) + 1] = brickNumber;
                            answer[(row * 2) + 2, (col * 2) + 1] = brickSeparator;
                        }
                        else
                        {
                            //else place the brick horizontally
                            matrixLayer2[row, col] = answer[(row * 2) + 1, (col * 2) + 1] = brickNumber;
                            matrixLayer2[row, col + 1] = answer[(row * 2) + 1, (col * 2) + 3] = brickNumber;
                            answer[(row * 2) + 1, (col * 2) + 2] = brickSeparator;
                        }
                    }
                }
                Console.WriteLine();
            }
            return matrixLayer2;
        }
    }

}

