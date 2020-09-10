using System;
using System.Collections.Generic;
using Algorithms.DS;

namespace Algorithms.Search
{
    public class DepathFirstSearch
    {
        public static IList<int> GetDFSLevelOrder(BinaryTreeNode rootNode)
        {
            var output = new List<int>();
            if(null == rootNode)
            {
                return output;
            }
            output.Add(rootNode.Value);
            if(null != rootNode.LeftNode)
            {
                output.AddRange(GetDFSLevelOrder(rootNode.LeftNode));
            }
            if(null != rootNode.RightNode)
            {
                output.AddRange(GetDFSLevelOrder(rootNode.RightNode));
            }
            return output;
        }
    }
}