using System;

namespace _005_Random_Pick_with_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array w of positive integers, where w[i] describes the weight of index i, 
               write a function pickIndex which randomly picks an index in proportion to its weight.

             * Note:
             *   1 <= w.length <= 10000
             *   1 <= w[i] <= 10^5
             *   pickIndex will be called at most 10000 times.

             * Example 1:
             * Input: 
             * ["Solution","pickIndex"]
             * [[[1]],[]]
             * Output: [null,0]
             */

            var w = new int[] { 1 };
            Solution obj = new Solution(w);
            int param_1 = obj.PickIndex();

            Console.WriteLine(param_1);
        }
    }

    public class Solution
    {
        private int[] _weights;
        private int _length;

        public Solution(int[] w)
        {
            _weights = w;
            _length = w.Length - 1;
        }

        public int PickIndex()
        {
            return new Random().Next(0, _length);
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(w);
     * int param_1 = obj.PickIndex();
     */
}
