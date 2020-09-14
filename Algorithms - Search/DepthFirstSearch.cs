using System;
using System.Collections.Generic;
using Algorithms.DS;

namespace Algorithms.Search
{
    public class DepthFirstSearch
    {
        public static IList<int> GetDFSLevelOrderUsingRecursion(BinaryTreeNode rootNode)
        {
            var output = new List<int>();
            if(null == rootNode)
            {
                return output;
            }
            output.Add(rootNode.Value);
            if(null != rootNode.LeftNode)
            {
                output.AddRange(GetDFSLevelOrderUsingRecursion(rootNode.LeftNode));
            }
            if(null != rootNode.RightNode)
            {
                output.AddRange(GetDFSLevelOrderUsingRecursion(rootNode.RightNode));
            }
            return output;
        }

        public static IList<int> GetDFSLevelOrder(BinaryTreeNode node)
        {
            var output = new List<int>();
            var stack = new Stack<BinaryTreeNode>();
            stack.Push(node);
            while(stack.Count > 0)
            {
                var currentNode = stack.Pop();
                output.Add(currentNode.Value);
                if(null != currentNode.RightNode)
                {
                    stack.Push(currentNode.RightNode);
                }
                if(null != currentNode.LeftNode)
                {
                    stack.Push(currentNode.LeftNode);
                }
                
            }
            return output;
        }
    }
}