using System;

namespace _006_Queue_Reconstruction_by_Height
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Suppose you have a random list of people standing in a queue. 
               Each person is described by a pair of integers (h, k), 
               where h is the height of the person and k is the number of people in front of this person who have a height greater than or equal to h. 
               Write an algorithm to reconstruct the queue.

             * Note:
             * The number of people is less than 1,100.
             
             * Example
             * Input:
             * [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
             * Output:
             * [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]
             */

            var people = new int[6][];
            people[0] = new int[] { 7, 0 };
            people[1] = new int[] { 4, 4 };
            people[2] = new int[] { 7, 1 };
            people[3] = new int[] { 5, 0 };
            people[4] = new int[] { 6, 1 };
            people[5] = new int[] { 5, 2 };

            var solution = new Solution();

            solution.ReconstructQueue(people);
        }
    }

    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            throw new NotImplementedException();
        }
    }
}
