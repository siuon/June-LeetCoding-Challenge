using System;

namespace _027_Perfect_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.
   
               Example 1:
   
               Input: n = 12
               Output: 3 
               Explanation: 12 = 4 + 4 + 4.
            */

            var n = 12;

            var solution = new Solution();

            Console.WriteLine(solution.NumSquares(n) == 3);
        }
    }

    public class Solution
    {
        public int NumSquares(int n)
        {
            throw new NotImplementedException();
        }
    }
}
