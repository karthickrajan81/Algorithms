using System;
using System.Collections.Generic;

namespace Algorithms.DS
{
    public class TreeTraverser
    {       
        public List<int> GetPreOrderList(BinaryTreeNode rootNode)
        {
            var result = new List<int>();            
            if(null != rootNode)
            {        
                result.Add(rootNode.Value);                    
                result.AddRange(GetPreOrderList(rootNode.LeftNode));                      
                result.AddRange(GetPreOrderList(rootNode.RightNode));
            }
            return result;
        }

        public List<int> GetInOrderList(BinaryTreeNode rootNode)
        {
            var result = new List<int>();            
            if(null != rootNode)
            {
                result.AddRange(GetInOrderList(rootNode.LeftNode));
                result.Add(rootNode.Value);                    
                result.AddRange(GetInOrderList(rootNode.RightNode));
            }
            return result;
        }

        public List<int> GetPostOrderList(BinaryTreeNode rootNode)
        {
            var result = new List<int>();            
            if(null != rootNode)
            {                             
                result.AddRange(GetPostOrderList(rootNode.LeftNode));                      
                result.AddRange(GetPostOrderList(rootNode.RightNode));
                result.Add(rootNode.Value);     
            }
            return result;
        }
    }
}