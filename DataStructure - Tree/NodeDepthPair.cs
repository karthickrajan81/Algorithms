using System;
namespace Algorithms.DS
{
public class NodeDepthPair
{
    public BinaryTreeNode Node { get; }

    public int Depth { get; }

    public NodeDepthPair(BinaryTreeNode node, int depth)
    {
        Node = node;
        Depth = depth;
    }
}
}