using System;

namespace _008_Power_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an integer, write a function to determine if it is a power of two.

             * Example 1:
             * Input: 1
             * Output: true 
                             0
             * Explanation: 2  =  1
             */

            var n = 1;
            var solution = new Solution();

            Console.WriteLine(solution.IsPowerOfTwo(n));
        }
    }

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            var oneCount = 0;
            var temp = 1;

            for (int i = 0; i < 32; i++)
            {
                if ((n & temp) != 0)
                {
                    oneCount++;
                }

                temp <<= 1;
            }

            return oneCount == 1 ? true : false;
        }
    }
}
