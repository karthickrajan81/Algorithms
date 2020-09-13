using System;

namespace Algorithms.DS
{
    public class BinaryTreeNode
    {        
        public int Value {get;}
        public BinaryTreeNode LeftNode {get; private set;}
        public BinaryTreeNode RightNode {get; private set;}

        public bool IsLeafNode
        {
            get
            {
             return (null == LeftNode && null == RightNode);
            }
        }

        public BinaryTreeNode(int value, BinaryTreeNode left= null, BinaryTreeNode right = null)
        {            
            Value = value;
            LeftNode = left;
            RightNode = right; 
        }

        public BinaryTreeNode InsertLeft(int value)
        {            
            LeftNode = new BinaryTreeNode(value);
            return LeftNode;
        }

        public BinaryTreeNode InsertRight(int value)
        {           
            RightNode = new BinaryTreeNode(value);
            return RightNode;
        }
    }    
}