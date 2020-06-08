using System;
using System.Linq;

namespace _007_Coin_Change_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are given coins of different denominations and a total amount of money. 
               Write a function to compute the number of combinations that make up that amount. 
               You may assume that you have infinite number of each kind of coin.
  
             * Example 1:
             * Input: amount = 5, coins = [1, 2, 5]
             * Output: 4
             * Explanation: there are four ways to make up the amount:
             * 5=5
             * 5=2+2+1
             * 5=2+1+1+1
             * 5=1+1+1+1+1

               Note:
               You can assume that
                 0 <= amount <= 5000
                 1 <= coin <= 5000
                 the number of coins is less than 500
                 the answer is guaranteed to fit into signed 32-bit integer
             */

            var amount = 5;
            var coins = new int[] { 1, 2, 5 };

            var solution = new Solution();

            Console.WriteLine(solution.Change(amount, coins) == 4);
        }
    }

    public class Solution
    {
        public int Change(int amount, int[] coins)
        {
            throw new NotImplementedException();
        }
    }
}
