using System;
using System.Collections.Generic;

namespace _030_Word_Search_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a 2D board and a list of words from the dictionary, find all words in the board.
   
               Each word must be constructed from letters of sequentially adjacent cell, 
               where "adjacent" cells are those horizontally or vertically neighboring. 
               The same letter cell may not be used more than once in a word.
   
               Example:
               Input: 
               board = [
                   ['o','a','a','n'],
                   ['e','t','a','e'],
                   ['i','h','k','r'],
                   ['i','f','l','v']
               ]

               words = ["oath","pea","eat","rain"]
   
               Output: ["eat","oath"]

               Note:

               All inputs are consist of lowercase letters a-z.
               The values of words are distinct.
            */

            var board = new char[4][];
            board[0] = new char[] { 'o', 'a', 'a', 'n' };
            board[0] = new char[] { 'e', 't', 'a', 'e' };
            board[0] = new char[] { 'i', 'h', 'k', 'r' };
            board[0] = new char[] { 'i', 'f', 'l', 'v' };

            var words = new string[] { "oath", "pea", "eat", "rain" };

            var solution = new Solution();

            solution.FindWords(board, words);
        }
    }

    public class Solution
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
