using System;
using System.Collections.Generic;
using System.Linq;

namespace _022_Single_Number_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a non-empty array of integers, every element appears three times except for one, which appears exactly once. 
               Find that single one.
   
               Note:
               Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
   
               Example 1:
                 Input: [2,2,3,2]
                 Output: 3
            */

            var nums = new int[] { 2, 2, 3, 2 };

            var solution = new Solution();

            Console.WriteLine(solution.SingleNumber(nums) == 3);
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var single = new HashSet<int>();
            var multi = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!single.Any(it => it == num) &&
                    !multi.Any(it => it == num))
                {
                    single.Add(num);
                }
                else
                {
                    single.Remove(num);
                    multi.Add(num);
                }
            }

            return single.First();
        }
    }
}
