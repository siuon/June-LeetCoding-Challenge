﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _012_Insert_Delete_GetRandom_O_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Design a data structure that supports all following operations in average O(1) time.
 
               1. insert(val): Inserts an item val to the set if not already present.
               2. remove(val): Removes an item val from the set if present.
               3. getRandom: Returns a random element from current set of elements. Each element must have the same probability of being returned.
             
             Example:
 
             // Init an empty set.
             RandomizedSet randomSet = new RandomizedSet();
 
             // Inserts 1 to the set. Returns true as 1 was inserted successfully.
             randomSet.insert(1);
 
             // Returns false as 2 does not exist in the set.
             randomSet.remove(2);
 
             // Inserts 2 to the set, returns true. Set now contains [1,2].
             randomSet.insert(2);
 
             // getRandom should return either 1 or 2 randomly.
             randomSet.getRandom();
 
             // Removes 1 from the set, returns true. Set now contains [2].
             randomSet.remove(1);
 
             // 2 was already in the set, so return false.
             randomSet.insert(2);
 
             // Since 2 is the only number in the set, getRandom always return 2.
             randomSet.getRandom();
            */

            RandomizedSet obj = new RandomizedSet();
        }
    }

    public class RandomizedSet
    {
        private HashSet<int> _nums;

        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            _nums = new HashSet<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (_nums.Any(it => it == val))
            {
                return false;
            }
            else
            {
                _nums.Add(val);

                return true;
            }
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!_nums.Any(it => it == val))
            {
                return false;
            }
            else
            {
                _nums.Remove(val);

                return true;
            }
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return _nums.ToArray()[new Random().Next(0, _nums.Count)];
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
