using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class Solution
    {

        // Find the divisors!
        public int[] Divisors(int n)
        {
            var finalResult = new List<int>();
            for (int i = 2; i < n; i++)
            {
                var currentNum = (double)n / i;


                if ((currentNum % 1) == 0)
                {
                    finalResult.Add(i);
                }
            }

            if (finalResult.Count() == 0)
            {
                return null;
            }
            return finalResult.ToArray();
        }
        //Replace With Alphabet Position
        public string AlphabetPosition(string text)
        {
            var sb = new StringBuilder();
            Regex.Matches(text, @"[A-Za-z]")
                       .Select(x => char.Parse(x.Value.ToLower()))
                       .Select(x => sb.Append($"{(int)x - 96} "))
                       .ToArray();

            return sb.ToString().TrimEnd();
        }
        //Duplicate Encoder
        public string DuplicateEncode(string word)
        {
            var sb = new StringBuilder(word.ToLower());

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < sb.Length; i++)
            {
                if (!dict.ContainsKey(sb[i]))
                {
                    dict[sb[i]] = 1;
                }
                else
                {
                    dict[sb[i]]++;
                }
            }


            for (int i = 0; i < sb.Length; i++)
            {
                if (dict.ContainsKey(sb[i]))
                {
                    if (dict[sb[i]] > 1)
                    {
                        sb[i] = ')';
                    }
                    else
                    {
                        sb[i] = '(';
                    }
                }
            }

            return sb.ToString();
        }
        //best return new string(word
        //             .ToLower()
        //             .Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());


        //Beginner Series #3 Sum of Numbers
        public int GetSum(int a, int b)
        {
            // return Enumerable.Range(a, Math.Abs(a - b)).Sum();
            //if (b < a)
            //{
            //    return b;
            //}
            //var result = a;
            //for (int i = a+1; i <= b; i++)
            //{

            //    result += i;

            //}

            //return result;
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result += i;
            }

            return result;
        }

        //Maximum subarray sum
        public static int MaxSequence(int[] arr)
        {
            if (arr.All(x => x < 0))
            {
                return 0;
            }
            if (arr.All(x => x > 0))
            {
                return arr.Sum();
            }
            var biggestSum = 0;
            var currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int g = i; g < arr.Length; g++)
                {
                    currentSum += arr[g];
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                    }
                }
                currentSum = 0;
            }
            return biggestSum;
        }
        //Dubstep
        public static string SongDecoder(string input)
        {
            var sb = new StringBuilder();
            var result = input.Replace("WUB", " ").Split();

            foreach (var item in result)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    sb.Append($"{item} ");
                }
            }

            return sb.ToString().TrimEnd();
        }
        //Title Case
        public static string TitleCase(string title, string minorWords = "")
        {

            if (string.IsNullOrEmpty(title)) { return ""; }
            var result = MakeFirstLetterUpperCase(title);

            if (string.IsNullOrEmpty(minorWords))
            {
                return string.Join(" ", result);
            }
            var words = minorWords.Split().Select(x => x.ToLower()).ToList();

            for (int i = 1; i < result.Count; i++)
            {
                if (words.Contains(result[i].ToLower()))
                {
                    result[i] = result[i].ToLower();
                }
            }

            return string.Join(" ", result);
        }
        public static List<string> MakeFirstLetterUpperCase(string title)
                  => title.Split(" ")
                    .Select(x => x.First().ToString()
                    .ToUpper() + x.Substring(1).ToLower())
                    .ToList();
        //First non-repeating character
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.Substring(0, 1);
        }
        //Help the bookSeller!

        public static string StockSummary(string[] lstOfArt, String[] lstOf1stLetter)
        {

            var booksWithQunatity = lstOfArt.Select(x => x.Split(" ")).ToDictionary(c => c[0], c => c[1]);
            var result = lstOf1stLetter.ToDictionary(x => x, value => 0);

            foreach (var book in booksWithQunatity)
            {
                if (result.ContainsKey(book.Key[0].ToString()))
                {
                    result[book.Key[0].ToString()] += int.Parse(book.Value);
                }
            }
            var chekIfNoBooks = result.Where(x => x.Value != 0).ToList();
            if (chekIfNoBooks.Count == 0)
            {
                return string.Empty;
            }

            var output = result.Select(x => $"({x.Key} : {x.Value})").ToList();

            return string.Join(" - ", output);

        }
        //best
        //public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        //{
        //    if (!lstOfArt.Any()) return "";
        //    return string.Join(" - ",
        //      lstOf1stLetter.Select(c => string.Format("({0} : {1})", c,
        //        lstOfArt.Where(a => a[0] == c[0]).Sum(a => int.Parse(a.Split(' ')[1])))));
        //}

        //!parseInt() reloaded

        public static int ParseInt(string s)
        {
          var text = s.Split().ToArray();
          
            var numbers = new Dictionary<string,int>(){
                {"zero",0},{"one",1},{"two",2},{"three",3},
                {"four",4},{"five",5},{"six",6},
                {"seven",7},{"eight",8},{"nine",9},{"ten",10},
                 {"eleven",11},{"twelve",12},{"thirteen",13},
                {"fourteen",14},{"fifteen",15},{"sixteen",16},
                {"seventeen",17},{"eighteen",18},{"nineteen",19},
                 {"twenty",20},{"thirty",30},{"forty",40},
                {"fifty",50},{"sixty",60},{"seventy",70},
                {"eighty",80},{"ninety",90}

            };
            
            var result = new List<int>();
            foreach (var item in text)
            {
                if(item.Contains("-")){
                   var words = item.Split("-");
                  result.Add(numbers[words[0]]+numbers[words[1]]);
                }
                if(numbers.ContainsKey(item)){
                        result.Add(numbers[item]);
                }
            }
           

           
           return int.Parse(string.Join("",result));
        }

    }
}
