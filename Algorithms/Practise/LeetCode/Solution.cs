using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
   
        public class Solution
        {
            #region Solved
            public int NumberOfSteps(int num)
            {
                var result = 0;
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;

                    }
                    else if (num % 2 == 1)
                    {
                        num -= 1;

                    }
                    result++;
                }
                return result;

            }
            public string DefangIPaddr(string address)
            {

                var sb = new StringBuilder();
                for (int i = 0; i < address.Length; i++)
                {
                    if (address[i] == '.')
                    {
                        sb.Append("[.]");
                    }
                    else
                    {
                        sb.Append(address[i]);
                    }
                }

                return sb.ToString();

            }
            public int[] DecompressRLElist(int[] nums)
            {
                var result = new List<int>();
                var num = 0;
                int count = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (count % 2 == 1)
                    {
                        num = nums[i];
                    }
                    else
                    {

                        result.AddRange(Enumerable.Repeat(nums[i], num));
                    }
                    count++;
                }

                return result.ToArray();
            }
            public int SubtractProductAndSum(int n)
            {
                int firstNum = 1;
                int secondNum = 0;
                while (n > 0)
                {
                    var currentNum = n % 10;
                    firstNum *= currentNum;
                    secondNum += currentNum;
                    n = n / 10;
                }

                return firstNum - secondNum;
            }
            public int FindNumbers(int[] nums)
            {
                System.Console.WriteLine(Math.Floor(Math.Log10(555) + 1));
                return nums.Select(x => x.ToString().Length).Where(x => x % 2 == 0).Count();


            }
            public int BalancedStringSplit(string s)

            {
                var firstLetter = 0;
                var secondLetter = 0;
                int count = 0;

                foreach (var letter in s)
                {
                    if (letter == 'R')
                    {
                        firstLetter++;
                    }
                    else
                    {
                        secondLetter++;
                    }
                    if (firstLetter == secondLetter)
                    {
                        count++;
                    }
                }


                return count;
            }
            public int CountNegatives(int[][] grid)
            {

                return grid.Select(x => x.Count(c => c < 0)).Sum();


            }
            public int Maximum69Number(int num)
            {
                var numString = num.ToString().ToCharArray();

                for (int i = 0; i < numString.Length; i++)
                {
                    if (numString[i] != 57)
                    {
                        numString[i] = '9';
                        break;
                    }
                }
                return int.Parse(numString);


            }
            public static string Review(string args)
            {
                var a = args.Where((x, index) => index % 2 == 0);
                var b = args.Where((x, index) => index % 2 == 1);

                return new String(a.ToArray()) + " " + new String(b.ToArray());

            }
            //01. Recursive Array Sum
            public static int Sum(int[] array, int index)
            {
                if (index == array.Length)
                {
                    return 0;
                }
                return array[index] + Sum(array, index + 1);

            }
            //02. Recursive Factorial
            public static long Factorial(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
            //03. Recursive Drawing
            public static void Draw(int n)
            {
                if (n == 0)
                {
                    return;
                }
                Console.WriteLine(new string('*', n));
                Draw(n - 1);
                Console.WriteLine(new string('#', n));

            }
            //04. Generating 0/1 Vectors
            public static void Generate(int[] vector, int index)
            {
                if (index > vector.Length - 1)
                {
                    System.Console.WriteLine(string.Join(" - ", vector));
                    return;
                }
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(vector, index + 1);
                }

            }
            //05. Generating Combinations

            public static void Combinations(int[] nums, int[] result, int index, int border)
            {

                if (index >= result.Length)
                {
                    Console.WriteLine(string.Join(" ", result));
                    return;
                }
                for (int i = border; i < nums.Length; i++)
                {
                    result[index] = nums[i];
                    Combinations(nums, result, index + 1, i + 1);
                }


            }
            //!Credit Card Mask
            public static string Mask(string cc)
            {
                if (cc.Length < 4)
                {
                    return cc;
                }
                var a = cc.Length - 4;
                return new string('*', a) + cc.Substring(cc.Length - 4);
            }
            //!Isogram
            public static bool IsIsogram(string str)
            {
                if (str == "")
                {
                    return true;
                }
                var result = "";
                foreach (var l in str.ToLower())
                {
                    if (result.Contains(l))
                    {
                        return false;
                    }
                    result += l;
                }
                return true;
                // var result =  str.ToLower().Aggregate(new List<string>(),(text,word)=>{
                //         if(text.Any(x=>x== word.ToString())){
                //            text.Add("1");
                //         }
                //         text.Add(word.ToString());
                //         return text;
                //  });
                //  return result.Any(x=>x=="1") ? false : true;
                // return str.ToUpper().Distinct().Count() == str.Length;   
            }
            public static bool comp(int[] a, int[] b)
            {
                if (a == null || b == null)
                {
                    return true;
                }

                for (int i = 0; i < b.Length; i++)
                {
                    for (int g = 0; g < a.Length; g++)
                    {
                        if (Math.Pow(a[g], 2) == b[i])
                        {
                            a[g] = 0;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                return true;
            }
            public static int Past(int h, int m, int s)
            {
                return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
            }
        #endregion
        public static void Map()
        {
            var a = int.Parse(Console.ReadLine());
            var map = new Dictionary<string, string>();
            for (int i = 0; i < a; i++)
            {
                var input = Console.ReadLine().Split();

                map[input[0]] = input[1];
            }
            string queryKey;
            while ((queryKey = Console.ReadLine()) != null)
            {
                if (map.ContainsKey(queryKey))
                {
                    Console.WriteLine("{0}={1}", queryKey, map[queryKey]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }


            }


        }
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).ToArray().Count(x => x == 1);
        }

        static void Binary(int n)
        {
            string binaryNum = Convert.ToString(n, 2);
            var result = Regex.Matches(binaryNum, @"(1)*").OfType<Match>().Select(match => match.Value).OrderByDescending(length => length).ToArray()[0].Count();

            Console.WriteLine(result);

        }
        static void ShiftMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var result = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {

                    result[g, matrix.GetLength(0) - 1 - i] = matrix[i, g];
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {

                for (int h = 0; h < result.GetLength(1); h++)
                {
                    Console.Write(result[i, h]);
                }
                Console.WriteLine();

            }
        }
    }
    }

