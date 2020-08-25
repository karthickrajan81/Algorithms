using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.DS
{
    internal class CircularQueue
    {
        private int[] _items;
        private int _head;
        private int _tail;
        private int maxIndex;
        public CircularQueue(int queueLength)
        {
            _items = new int[queueLength];
            _head = -1;
            _tail = -1;
            maxIndex = queueLength - 1;
        }

        public bool enQueue(int item)
        {
            if((_head == 0 && _tail == maxIndex) ||
                (_tail + 1 == _head))
                {
                    return false;
                }
                else if(_head == -1)
                {
                    _head = _tail = 0;
                    _items[_tail] = item;
                    return true;
                }
                else if(_tail == maxIndex && _head != 0)
                {
                    _tail = 0;
                    _items[_tail]=item;                    
                    return true;
                }
                else
                {
                   _tail++;
                  _items[_tail] = item;
                  return true;
                }            
        }

        public bool deQueue()
        {
            if(_head < 0)
            {
                return false;
            }
            _items[_head] = 0;              

      if(_head == _tail)
        _head = _tail = -1;
      else if(_head == maxIndex)
          _head = 0;
        else
          _head++;
            return true;
        }

        public int Front()
        {
            if(_head < 0)
            {
                return -1;
            }
            return _items[_head];
        }

        public int Rear()
        {
            if(_tail > maxIndex || _tail < 0)
            {
                return -1;
            }
            return _items[_tail];
        }

        public bool isEmpty()
        {
            return (_tail == -1 && _head == -1);
        }

        public bool isFull()
        {
            return ((_head == 0 && _tail == maxIndex) ||
                (_tail + 1 == _head));
        }

        public int[] GetAll()
        {
            return _items;
        }
    }
}