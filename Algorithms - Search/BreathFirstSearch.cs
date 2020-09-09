using System;
using System.Collections.Generic;
using Algorithms.DS;

namespace Algorithms.Search
{
    public class BreathFirstSearch
    {
        public static List<List<int>> GetBFSLevelOrder(BinaryTreeNode rootNode) 
        {
            var result = new List<List<int>>();
            var itemsQ = new Queue<BinaryTreeNode>();
            if(rootNode != null)
            {
                var item = new List<int>();              
                itemsQ.Enqueue(rootNode);   
                while(itemsQ.Count > 0)
                {
                    var siblings = new List<int>();
                    int currentLevelCount = itemsQ.Count;
                    for(int i= 0;i<currentLevelCount;i++)             
                    {
                        var currentNode = itemsQ.Dequeue();
                        siblings.Add(currentNode.Value);
                        if(null != currentNode.LeftNode)
                        {
                            itemsQ.Enqueue(currentNode.LeftNode);
                        }
                        if(null != currentNode.RightNode)
                        {
                            itemsQ.Enqueue(currentNode.RightNode);
                        }
                    }
                    if(siblings.Count > 0)
                    {
                        result.Add(siblings);
                    }
                }

            }
            return result;
        }      
    }
}