using System;
using System.Text.RegularExpressions;
using static CodeWars.Solution;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] { "A", "B" };
            // Console.WriteLine(Solution.ParseInt("seven hundred eighty-three thousand nine hundred and nineteen" ));
            // Console.WriteLine(Solution.ParseInt("two hundred forty-six"));
            var solution = new Solution();
            // Console.WriteLine(string.Join(" ", Solution.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3)));
            var node = new Node(1);

            // System.Console.WriteLine(Node.Count(node, x => x == 1));

            var result = Solution.DataReverse(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 });
            System.Console.WriteLine(string.Join("", result));

        }
        // var text = "Hello Radislav Danev how are you?";

        // // System.Console.WriteLine(text.Replace());
        // var result = new Regex("([A-Z])").Matches(text);
        // System.Console.WriteLine(result);
        // System.Console.WriteLine(string.Join(" ",result));

    }
}

