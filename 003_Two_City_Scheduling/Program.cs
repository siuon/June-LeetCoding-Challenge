using System;

namespace _003_Two_City_Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * There are 2N people a company is planning to interview. 
               The cost of flying the i-th person to city A is costs[i][0], 
               and the cost of flying the i-th person to city B is costs[i][1].
             * Return the minimum cost to fly every person to a city such that exactly N people arrive in each city.
  
             * Example 1:
             * Input: [[10,20],[30,200],[400,50],[30,20]]
             * Output: 110

             * Explanation: 
             * The first person goes to city A for a cost of 10.
             * The second person goes to city A for a cost of 30.
             * The third person goes to city B for a cost of 50.
             * The fourth person goes to city B for a cost of 20.
  
             * The total minimum cost is 10 + 30 + 50 + 20 = 110 to have half the people interviewing in each city.

             * Note:
             *   1 <= costs.length <= 100
             *   It is guaranteed that costs.length is even.
             *   1 <= costs[i][0], costs[i][1] <= 1000
             */

            // [[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]
            // 1859

            var costs = new int[6][];
            costs[0] = new int[] { 259, 770 };
            costs[1] = new int[] { 448, 54 };
            costs[2] = new int[] { 926, 667 };
            costs[3] = new int[] { 184, 139 };
            costs[4] = new int[] { 840, 118 };
            costs[5] = new int[] { 577, 469 };

            var solution = new Solution();

            Console.WriteLine(solution.TwoCitySchedCost(costs) == 1859);
        }
    }

    public class Solution
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            throw new NotImplementedException();
        }
    }
}
