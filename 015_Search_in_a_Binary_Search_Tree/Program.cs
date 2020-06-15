using System;

namespace _015_Search_in_a_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Given the root node of a binary search tree (BST) and a value. 
              You need to find the node in the BST that the node's value equals the given value. 
              Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
  
              For example, 
              Given the tree:
                   4
                  / \
                 2   7
                / \
               1   3
  
              And the value to search: 2
              You should return this subtree:
  
                  2     
                 / \   
                1   3
              In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.
              Note that an empty tree is represented by NULL, therefore you would see the expected output (serialized tree format) as [], not null.
            */

            var node1 = new TreeNode(1);
            var node3 = new TreeNode(3);
            var node2 = new TreeNode(2, node1, node3);
            var node7 = new TreeNode(7);
            var node4 = new TreeNode(4, node2, node7);

            var solution = new Solution();

            solution.SearchBST(node4, 2);
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
        private int _targetVal;

        public TreeNode SearchBST(TreeNode root, int val)
        {
            _targetVal = val;

            return GoTree(root);
        }

        private TreeNode GoTree(TreeNode node)
        {
            if (node == null ||
                node.val == _targetVal)
            {
                return node;
            }

            if (_targetVal > node.val)
            {
                return GoTree(node.right);
            }
            else 
            {
                return GoTree(node.left);
            }
        }
    }
}
