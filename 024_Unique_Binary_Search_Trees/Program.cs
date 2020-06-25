using System;

namespace _024_Unique_Binary_Search_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?
   
               Example:
               Input: 3
               Output: 5

               Explanation:
               Given n = 3, there are a total of 5 unique BST's:
   
                  1         3     3      2      1
                   \       /     /      / \      \
                    3     2     1      1   3      2
                   /     /       \                 \
                  2     1         2                 3
            */

            var n = 3;

            var solution = new Solution();

            Console.WriteLine(solution.NumTrees(n) == 5);
        }
    }

    public class Solution
    {
        public int NumTrees(int n)
        {
            throw new NotImplementedException();
        }
    }
}
