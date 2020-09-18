using System;
using Algorithms.DS;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class FindSecondLargestInBST
    {

        public static int GetLargest(BinaryTreeNode node)
        {                      
            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(node);
            int max = node.Value;
            while(queue.Count > 0)
            {
                var currentNode =  queue.Dequeue();
                max = currentNode.Value;
                if(currentNode.RightNode != null)
                {
                    queue.Enqueue(currentNode.RightNode);                    
                }
            }
            return max;
        }
        public static int GetSecondLargest(BinaryTreeNode node)
        {
            if(null == node || (null == node.RightNode && null == node.LeftNode))
            {
                throw new ArgumentException();
            }
            var currentNode = node;
            while(true)
            {
                if(currentNode.RightNode == null && currentNode.LeftNode != null)
                {
                   return GetLargest(currentNode.LeftNode);
                }

                if(currentNode.RightNode  != null && currentNode.RightNode.LeftNode == null && currentNode.RightNode.RightNode == null)
                {
                    return currentNode.Value;
                }
                currentNode = currentNode.RightNode;
            }
        }
    }
}