using System;

namespace _029_Unique_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
   
               The robot can only move either down or right at any point in time. 
               The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
   
               How many possible unique paths are there?

               Example 1:

               Input: m = 3, n = 2
               Output: 3

               Explanation:
               From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
               1. Right -> Right -> Down
               2. Right -> Down -> Right
               3. Down -> Right -> Right
            */

            var m = 3;
            var n = 2;

            var solution = new Solution();

            //Console.WriteLine(solution.UniquePaths(m, n) == 3);

            m = 23;
            n = 12;

            solution.UniquePaths(m, n);
        }
    }

    public class Solution
    {
        private int _pathCount;
        private int _m;
        private int _n;

        public int UniquePaths(int m, int n)
        {
            _m = m;
            _n = n;

            GoPath(1, 1);

            Console.WriteLine(_pathCount);

            return _pathCount;
        }

        private void GoPath(int m, int n)
        {
            if (m == _m && n == _n)
            {
                _pathCount++;
            }

            if (m + 1 <= _m)
            {
                GoPath(m + 1, n);
            }

            if (n + 1 <= _n)
            {
                GoPath(m, n + 1);
            }
        }
    }
}
