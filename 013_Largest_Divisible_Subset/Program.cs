using System;

namespace _013_Largest_Divisible_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Given a set of distinct positive integers, 
              find the largest subset such that every pair (Si, Sj) of elements in this subset satisfies:
  
              Si % Sj = 0 or Sj % Si = 0.
  
              If there are multiple solutions, return any subset is fine.
  
              Example 1:
  
              Input: [1,2,3]
              Output: [1,2] (of course, [1,3] will also be ok)
            */

            var nums = new int[] { 1, 2, 3 };
            var solution = new Solution();

            solution.LargestDivisibleSubset(nums);
        }
    }

    public class Solution
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}
