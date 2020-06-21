using System;

namespace _020_Permutation_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               The set [1,2,3,...,n] contains a total of n! unique permutations.
   
               By listing and labeling all of the permutations in order, we get the following sequence for n = 3:
   
               "123"
               "132"
               "213"
               "231"
               "312"
               "321"
               
               Given n and k, return the kth permutation sequence.
   
               Note:
                 Given n will be between 1 and 9 inclusive.
                 Given k will be between 1 and n! inclusive.
               
               Example 1:
               Input: n = 3, k = 3
               Output: "213"
            */

            var n = 3;
            var k = 3;

            var solution = new Solution();

            Console.WriteLine(solution.GetPermutation(n, k) == "213");
        }
    }

    public class Solution
    {
        public string GetPermutation(int n, int k)
        {
            throw new NotImplementedException();
        }
    }
}
