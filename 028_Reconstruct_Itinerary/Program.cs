using System;
using System.Collections.Generic;

namespace _028_Reconstruct_Itinerary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a list of airline tickets represented by pairs of departure and arrival airports [from, to], 
               reconstruct the itinerary in order. All of the tickets belong to a man who departs from JFK. Thus, 
               the itinerary must begin with JFK.
   
               Note:
                 1. If there are multiple valid itineraries, 
                    you should return the itinerary that has the smallest lexical order when read as a single string. 
                    For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
                 2. All airports are represented by three capital letters (IATA code).
                 3. You may assume all tickets form at least one valid itinerary.
                 4. One must use all the tickets once and only once.
               
               Example 1:
               Input: [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]
               Output: ["JFK", "MUC", "LHR", "SFO", "SJC"]
            */

            var tickets = new List<List<string>>();
            tickets.Add(new List<string>() { "MUC", "LHR" });
            tickets.Add(new List<string>() { "JFK", "MUC" });
            tickets.Add(new List<string>() { "SFO", "SJC" });
            tickets.Add(new List<string>() { "LHR", "SFO" });

            var solution = new Solution();

            solution.FindItinerary((IList<IList<string>>)tickets);
        }
    }

    public class Solution
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            throw new NotImplementedException();
        }
    }
}
