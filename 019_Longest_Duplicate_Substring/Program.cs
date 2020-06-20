using System;

namespace _019_Longest_Duplicate_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a string S, consider all duplicated substrings: (contiguous) substrings of S that occur 2 or more times.  
               (The occurrences may overlap.)
   
               Return any duplicated substring that has the longest possible length.  (If S does not have a duplicated substring, 
               the answer is "".)
   
               Example 1:
               Input: "banana"
               Output: "ana"

               Note:
                 2 <= S.length <= 10^5
                 S consists of lowercase English letters.
            */

            var S = "banana";

            var solution = new Solution();

            Console.WriteLine(solution.LongestDupSubstring(S) == "ana");
        }
    }

    public class Solution
    {
        public string LongestDupSubstring(string S)
        {
            throw new NotImplementedException();
        }
    }
}
