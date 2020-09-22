/*
You wrote a trendy new messaging app, MeshMessage, to get around flaky cell phone coverage.
Instead of routing texts through cell towers, your app sends messages via the phones of nearby users, 
passing each message along from one phone to the next until it reaches the intended recipient. 
Some friends have been using your service, and they're complaining that it takes a long time for messages to get delivered. 
After some preliminary debugging, you suspect messages might not be taking the most direct route from the sender to the recipient.
Given information about active users on the network, find the shortest route for a message from one user (the sender) to another (the recipient).
Return an array of users that make up this route.
*/
using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class MeshMessage
    {
       public static List<string> GetPath(Dictionary<string, string[]> input, string from, string to)
        {
            if (!input.ContainsKey(from))
            {
                throw new ArgumentException();
            }
            if (!input.ContainsKey(to))
            {
                throw new ArgumentException();
            }
            
            var qu = new Queue<string>();
            var visitedNodes = new HashSet<string>();
            var path = new Dictionary<string,string>();
            
            qu.Enqueue(from);
            visitedNodes.Add(from);
            path.Add(from, null);

            while(qu.Count > 0)
            {
                var current = qu.Dequeue();
                if(current == to)
                {
                    return ConstructPath(path,from, to);
                }
                foreach(var item in input[current])
                {
                    if(!visitedNodes.Contains(item))
                    {
                        qu.Enqueue(item);
                        visitedNodes.Add(item);
                        path.Add(item,current);
                    }
                }
            }
            return null;
        }

        private static List<string> ConstructPath(Dictionary<string, string> path, string from, string to)
        {
           var output = new List<string>();
           var current = to;
           while(current != null)
           {
               output.Add(current);
               current = path[current];
           }
           output.Reverse();
           return output;
        }

    }
}