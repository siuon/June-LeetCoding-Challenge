using System;

namespace _010_Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a sorted array and a target value, return the index if the target is found. 
               If not, return the index where it would be if it were inserted in order.
             * You may assume no duplicates in the array.

             * Example 1:
             *   Input: [1,3,5,6], 5
             *   Output: 2
             */

            var nums = new int[] { 1, 3, 5, 6 };
            var target = 5;

            var solution = new Solution();

            Console.WriteLine(solution.SearchInsert(nums, target) == 2);
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[0] > target)
            {
                return 0;
            }

            if (nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }

            var position = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    position = i;

                    break;
                }
                else if (nums[i - 1] < target &&
                    target < nums[i])
                {
                    position = i;

                    break;
                }
            }

            return position;
        }
    }
}
