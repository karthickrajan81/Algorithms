using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.DS
{
    internal class QueueDs
    {
        private List<int> items;

        public QueueDs()
        {
           items = new List<int>();
        }
        public void enQueue(int item)
        {
            items.Add(item);
        }

        public int deQueue()
        {           
            if( items.Count == 0)
                return -1;

            var value = items[0];
            items.RemoveAt(0);
            return value;
        }

        public int Front()
        {
            if( items.Count == 0)
                return -1;            
            return items[items.Count - 1];
        }

        public bool isEmpty()
        {
            return items.Count == 0;
        }

        public List<int> GetAllItems()
        {
            return items;
        }
    }
}