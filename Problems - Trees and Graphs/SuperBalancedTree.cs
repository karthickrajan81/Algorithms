using System;
using System.Collections.Generic;
using Algorithms.DS;

namespace Problems.TreesAndGraphs
{
    /* Write a method to see if a binary tree ↴ is "superbalanced" (a new tree property we just made up).
    A tree is "superbalanced" if the difference between the depths of any two leaf nodes ↴ is no greater than one. */
    public class SuperBalancedTree
    {
        public static bool IsSuperBalanced(BinaryTreeNode root)
        {
            if(null == root)
            {
                return true;
            }
            var stack = new Stack<NodeDepthPair>();
            var nodeDepthPair = new NodeDepthPair(root,0);
            var depths = new List<int>();

            stack.Push(nodeDepthPair);
            while(stack.Count > 0)
            {
                var currentNodeDepthPair = stack.Pop();
                var node = currentNodeDepthPair.Node;
                var level = currentNodeDepthPair.Depth;
                
                if(node.IsLeafNode)
                {
                    if(!depths.Contains(level))
                    {
                        depths.Add(level);
                        if(depths.Count > 2 || (depths.Count == 2 && Math.Abs(depths[0]-depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if(node.LeftNode != null)
                    {
                        var leftNodeDepthPair = new NodeDepthPair(node.LeftNode,level+1);
                        stack.Push(leftNodeDepthPair);
                    }
                    if(node.RightNode != null)
                    {
                        var rightNodeDepthPair = new NodeDepthPair(node.RightNode,level+1);
                        stack.Push(rightNodeDepthPair);
                    }
                }
            }
            return true;
        }
        public static bool IsSuperBalancedUsingRecursion(BinaryTreeNode rootNode)
        {          
            var depths = GetAllNodeDepths(rootNode, 0);
            if(depths.Count <= 1 )
            {
                return true;
            }
            for(int i = 0;i<depths.Count -1;i++)
            {
                for(int j= i+1;j< depths.Count;j++)
                {
                   if(Math.Abs(depths[i]-depths[j])> 1)
                   {
                       return false;
                   }
                }
            }
            return true;
        }

        private static List<int> GetAllNodeDepths(BinaryTreeNode node, int currentLevel)
        {
            var depths = new List<int>();
            if(null == node )
            {
                return depths;
            } 
            if(node.IsLeafNode)         
            {
                currentLevel++;
                depths.Add(currentLevel);
                return depths;
            }
            if(node.LeftNode != null)
            {
               var leftDepth = currentLevel+1;
               depths.AddRange(GetAllNodeDepths(node.LeftNode, leftDepth));
            }
            if(node.RightNode != null)
            {
                var rightDepth = currentLevel+1;
                depths.AddRange(GetAllNodeDepths(node.RightNode, rightDepth));
            }
            return depths;
        }
    }
}