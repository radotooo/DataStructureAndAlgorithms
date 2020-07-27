using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class Solve
    {
        public static string SumAndAverage(int[] input)
        {
            if (input.Length == 0)
            {
                return $"Sum={0}; Average={0:F2}";

            }
            return $"Sum={input.Sum()}; Average={input.Average():F2}";
        }

        public static void LongestSubsequense(int[] input)
        {

            var longestSequence = new List<int>();
            var currentSequence = new List<int>();



            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentSequence.Add(input[j]);

                    }
                    else
                    {
                        break;
                    }
                }
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = currentSequence.Select(x => x).ToList();
                }
                currentSequence.Clear();

            }


            Console.WriteLine(string.Join(" ", longestSequence));




        }
        public static void RemoveOddOccurence()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dict = new ConcurrentDictionary<int, int>();
            foreach (var item in input)
            {
                dict.AddOrUpdate(item, 1, (a, b) => b + 1);
            }
            var numToRemove = dict.Where(x => x.Value % 2 == 1)
                                  .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in numToRemove)
            {
                input.RemoveAll(x => x == item.Key);
            }
            Console.WriteLine(string.Join(" ", input));
        }

        //	Reverse Numbers with a Stack
       

    }
}
