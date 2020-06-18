using System;

namespace _017_Surrounded_Regions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a 2D board containing 'X' and 'O' (the letter O), capture all regions surrounded by 'X'.
               A region is captured by flipping all 'O's into 'X's in that surrounded region.

               Example:
               X X X X
               X O O X
               X X O X
               X O X X

               After running your function, the board should be:
               X X X X
               X X X X
               X X X X
               X O X X

               Explanation:
               Surrounded regions shouldn’t be on the border, which means that any 'O' on the border of the board are not flipped to 'X'. 
               Any 'O' that is not on the border and it is not connected to an 'O' on the border will be flipped to 'X'. 
               Two cells are connected if they are adjacent cells connected horizontally or vertically.
            */

            var board = new char[4][];
            board[0] = new char[] { 'X', 'X', 'X', 'X' };
            board[0] = new char[] { 'X', 'O', 'O', 'X' };
            board[0] = new char[] { 'X', 'X', 'O', 'X' };
            board[0] = new char[] { 'X', 'O', 'X', 'X' };

            var solution = new Solution();

            solution.Solve(board);
        }
    }

    public class Solution
    {
        public void Solve(char[][] board)
        {
            throw new NotImplementedException();
        }
    }
}
