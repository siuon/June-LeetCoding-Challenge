using System;

namespace _001_Invert_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Invert a binary tree.
 
             *Example:
             *Input:
             *      4
             *    /   \
             *   2     7
             *  / \   / \
             * 1   3 6   9
 
             *Output:
             *      4
             *    /   \
             *   7     2
             *  / \   / \
             * 9   6 3   1
             */

            var root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(7);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            var solution = new Solution();

            solution.InvertTree(root);
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
        public TreeNode InvertTree(TreeNode root)
        {
            var newRoot = new TreeNode(root.val);

            GoTree(root, ref newRoot);   

            return newRoot;
        }

        private void GoTree(TreeNode node, ref TreeNode newNode)
        {
            newNode = new TreeNode(node.val);

            if (node.right != null)
            {
                GoTree(node.right, ref newNode.left);
            }

            if (node.left != null)
            {
                GoTree(node.left, ref newNode.right);
            }
        }
    }
}
