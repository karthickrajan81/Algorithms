using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.DS;

namespace Algorithms.Problems
{
    /* Write a method to check that a binary tree ↴ is a valid binary search tree. ↴*/
    public class BinaryTree
    {
        public static bool IsBalanced(BinaryTreeNode root)
        {
           return  IsBalancedRecursion(root,null,null);
        }

        private static bool IsBalancedRecursion(BinaryTreeNode node, int? min, int? max)
        {
            if(null == node)
            {
                return true;
            }
            if((null != min &&  node.Value <= min) || (null != max && node.Value >= max))
            {
                return false;
            }

            return IsBalancedRecursion(node.LeftNode,min,node.Value) && IsBalancedRecursion(node.RightNode,node.Value,max);
        }
    }
}