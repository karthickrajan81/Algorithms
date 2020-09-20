using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms.DS
{
    public class GraphNode
    {
        public string Label { get; }
        public ISet<GraphNode> Neighbors { get; }
        public string Color { get; set; }
        public bool HasColor { get { return Color != null; } }

        public GraphNode(string label)
        {
            Label = label;
            Neighbors = new HashSet<GraphNode>();
        }

        public void AddNeighbor(GraphNode neighbor)
        {
            Neighbors.Add(neighbor);
        }
    }

    public class GraphHelper
    {
        public static bool IsGraphColoringValid(GraphNode[] graph)
        {
            var nonColoredNode = graph.FirstOrDefault(n => !n.HasColor);
            if (nonColoredNode != null)
            {
                Debug.WriteLine($"Found non-colored node {nonColoredNode.Label}");
                return false;
            }

            int maxDegree = 0;
            var usedColors = new HashSet<string>();

            foreach (var node in graph)
            {
                maxDegree = Math.Max(maxDegree, node.Neighbors.Count);
                usedColors.Add(node.Color);
            }

            var allowedColorCount = maxDegree + 1;

            if (usedColors.Count > allowedColorCount)
            {
                Debug.WriteLine("Too many colors:"
                    + $" {allowedColorCount} allowed, but {usedColors.Count} actually used");
                    return false;
            }

            foreach (var node in graph)
            {
                var neighbor = node.Neighbors.FirstOrDefault(n => n.Color == node.Color);
                if (neighbor != null)
                {
                    Debug.WriteLine($"Neighbor nodes {node.Label} and {neighbor.Label}"
                        + $" have the same color {node.Color}");
                    return false;
                }
            }
            return true;
        }
    }
}