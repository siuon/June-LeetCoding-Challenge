using System;
using System.Collections.Generic;
using System.Linq;

namespace _025_Find_the_Duplicate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), 
               prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
   
               Example 1:
               Input: [1,3,4,2,2]
               Output: 2
   
               Note:
                 You must not modify the array (assume the array is read only).
                 You must use only constant, O(1) extra space.
                 Your runtime complexity should be less than O(n2).
                 There is only one duplicate number in the array, but it could be repeated more than once.
            */

            var input = new int[] { 1, 3, 4, 2, 2 };

            var solution = new Solution();

            Console.WriteLine(solution.FindDuplicate(input) == 2);
        }
    }

    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            var pool = new HashSet<int>();
            var duplicateNumber = 0;

            foreach (var num in nums)
            {
                if (!pool.Any(it => it == num))
                {
                    pool.Add(num);
                }
                else
                {
                    duplicateNumber = num;
                }
            }

            return duplicateNumber;
        }
    }
}
