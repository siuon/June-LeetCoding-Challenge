using System;

namespace _021_Dungeon_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               The demons had captured the princess (P) and imprisoned her in the bottom-right corner of a dungeon. 
               The dungeon consists of M x N rooms laid out in a 2D grid. 
               Our valiant knight (K) was initially positioned in the top-left room and must fight his way through the dungeon to rescue the princess.
   
               The knight has an initial health point represented by a positive integer. 
               If at any point his health point drops to 0 or below, he dies immediately.
   
               Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; 
               other rooms are either empty (0's) or contain magic orbs that increase the knight's health (positive integers).
   
               In order to reach the princess as quickly as possible, the knight decides to move only rightward or downward in each step.
   
               
   
               Write a function to determine the knight's minimum initial health so that he is able to rescue the princess.
   
               For example, given the dungeon below, the initial health of the knight must be at least 7 if he follows the optimal path 
               RIGHT-> RIGHT -> DOWN -> DOWN.
   
               -2 (K)	-3	 3
               -5	   -10	 1
               10	    30	-5 (P)
               
   
               Note:
   
               The knight's health has no upper bound.
               Any room can contain threats or power-ups, even the first room the knight enters and the bottom-right room 
               where the princess is imprisoned.
            */

            var dungeon = new int[3][];
            dungeon[0] = new int[] { -2, -3, 3 };
            dungeon[1] = new int[] { -5, -10, 1 };
            dungeon[2] = new int[] { 10, 30, -5 };

            var solution = new Solution();

            // dungeon = new int[1][];
            // dungeon[0] = new int[] { 2, 1 };

            Console.WriteLine(solution.CalculateMinimumHP(dungeon) == 7);
        }
    }

    public class Solution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            throw new NotImplementedException();
        }
    }
}
