using System;
using System.Collections.Generic;
using Algorithms.DS;

namespace Algorithms.Problems
{
    public class GraphColoring
    {
        static string[] _colors = new string[] {"Red", "Green", "Blue", "Orange", "Yellow", "White"};
        public static void ColorGraph(GraphNode[] graph, string[] colors)
        {
            if(graph.Length <= 1)
            {
                throw new ArgumentException();
            }
            int i=0;
            while(i<graph.Length)
            {
                if(!graph[i].HasColor)
                {
                    var colorsAvailable = new List<string>(colors);
                    foreach(var neighbor in graph[i].Neighbors)
                    {
                        if(neighbor.HasColor)
                        {
                            colorsAvailable.Remove(neighbor.Color);
                        }
                    }
                    if(colorsAvailable.Count > 0)
                    {
                        graph[i].Color = colorsAvailable[0];
                    }
                }
                i++;
            }
        }
    }
}