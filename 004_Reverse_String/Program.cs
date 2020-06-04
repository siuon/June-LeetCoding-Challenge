using System;

namespace _004_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a function that reverses a string. The input string is given as an array of characters char[].
             * Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
             * You may assume all the characters consist of printable ascii characters.
  
             * Example 1:
             * Input: ["h","e","l","l","o"]
             * Output: ["o","l","l","e","h"]
             */

            var s = new char[] { 'h', 'e', 'l', 'l', 'o' };

            var solution = new Solution();

            var before = s.ToString();
            var after = s.ToString();

            Console.WriteLine(before == after);
        }
    }

    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var half = s.Length / 2;
            char temp;
            int endIndex;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < half)
                {
                    endIndex = (s.Length - 1) - i;

                    temp = s[i];
                    s[i] = s[endIndex];
                    s[endIndex] = temp;
                }
            }
        }
    }
}
