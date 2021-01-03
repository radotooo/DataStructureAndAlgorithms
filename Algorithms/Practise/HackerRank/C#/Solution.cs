
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

    }
}
