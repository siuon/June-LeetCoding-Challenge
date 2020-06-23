using System;

namespace _023_Count_Complete_Tree_Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Given a complete binary tree, count the number of nodes.
   
               Note:
               Definition of a complete binary tree from Wikipedia:
               In a complete binary tree every level, except possibly the last, 
               is completely filled, and all nodes in the last level are as far left as possible. 
               It can have between 1 and 2h nodes inclusive at the last level h.

               Example:
               Input: 
                   1
                  / \
                 2   3
                / \  /
               4  5 6
   
               Output: 6
            */

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);
            root.left = new TreeNode(6);

            var solution = new Solution();

            Console.WriteLine(solution.CountNodes(root) == 6);
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
        private int _nodeCount;

        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            GoPah(root);

            return _nodeCount;
        }

        private void GoPah(TreeNode node)
        {
            _nodeCount++;

            if (node.left != null)
            {
                GoPah(node.left);
            }

            if (node.right != null)
            {
                GoPah(node.right);
            }
        }
    }
}
