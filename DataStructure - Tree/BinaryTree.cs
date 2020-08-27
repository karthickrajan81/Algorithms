using System;

namespace Algorithms.DS
{
    public class BinaryTreeNode
    {        
        public int Value {get;}
        public BinaryTreeNode LeftNode {get; private set;}
        public BinaryTreeNode RightNode {get; private set;}
        public BinaryTreeNode ParentNode {get; }

        public bool IsRootNode 
        {
            get 
            {
              return  null == ParentNode;
            }
        }

        public bool IsLeafNode
        {
            get
            {
             return (null == LeftNode && null == RightNode);
            }
        }

        public BinaryTreeNode(BinaryTreeNode parent,int value)
        {            
            Value = value;
            ParentNode = parent;
        }

        public BinaryTreeNode InsertLeft(int value)
        {            
            LeftNode = new BinaryTreeNode(this,value);
            return LeftNode;
        }

        public BinaryTreeNode InsertRight(int value)
        {           
            RightNode = new BinaryTreeNode(this,value);
            return RightNode;
        }
    }    
}