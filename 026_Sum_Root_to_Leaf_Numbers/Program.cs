using System;

namespace _026_Sum_Root_to_Leaf_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
               An example is the root-to-leaf path 1->2->3 which represents the number 123.
               Find the total sum of all root-to-leaf numbers.
               Note: A leaf is a node with no children.
   
               Example:
               Input: [1,2,3]
                   1
                  / \
                 2   3
               Output: 25
     
               Explanation:
               The root-to-leaf path 1->2 represents the number 12.
               The root-to-leaf path 1->3 represents the number 13.
               Therefore, sum = 12 + 13 = 25.
            */

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            var solution = new Solution();

            Console.WriteLine(solution.SumNumbers(root) == 25);
        }
    }

    /*
     * Definition for a binary tree node.
     */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        private int _sum;

        public int SumNumbers(TreeNode root)
        {
            if (root == null)
            {
                return _sum;
            }

            GoPath(root, root.val);

            return _sum;
        }

        private void GoPath(TreeNode node, int val)
        {
            if (node.left != null)
            {
                GoPath(node.left, val * 10 + node.left.val);
            }

            if (node.right != null)
            {
                GoPath(node.right, val * 10 + node.right.val);
            }

            if (node.left == null && node.right == null)
            {
                _sum += val;
            }
        }
    }
}
