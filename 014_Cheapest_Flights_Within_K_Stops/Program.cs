﻿using System;

namespace _014_Cheapest_Flights_Within_K_Stops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              There are n cities connected by m flights. Each flight starts from city u and arrives at v with a price w.
  
              Now given all the cities and flights, together with starting city src and the destination dst, 
              your task is to find the cheapest price from src to dst with up to k stops. If there is no such route, output -1.
  
              Example 1:
              Input: 
              n = 3, edges = [[0,1,100],[1,2,100],[0,2,500]]
              src = 0, dst = 2, k = 1
              Output: 200
              Explanation: 
              The graph looks like this:

                    0
              100 /   \  500
                 1  -  2
                   100

              Constraints:
                The number of nodes n will be in range [1, 100], with nodes labeled from 0 to n - 1.
                The size of flights will be in range [0, n * (n - 1) / 2].
                The format of each flight will be (src, dst, price).
                The price of each flight will be in the range [1, 10000].
                k is in the range of [0, n - 1].
                There will not be any duplicated flights or self cycles.
            */
        }
    }

    public class Solution
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            throw new NotImplementedException();
        }
    }
}
