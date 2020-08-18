using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.DS;
using Algorithms.Problems;
using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {          
            //ExecQueueDs(inputArray);
            //ExecCircularQueue(inputArray);
            //ExecMergeSort(inputArray);
            //ExecSelectionSort(inputArray);
            //ExecBubbleSort(inputArray);            
            //ExecMeetingRangeProblem();
            //ExecReverseString();
            //Todo: Convert these console test into unit test projects
            ExecReverseWords();
        }

        private static void ExecReverseWords()
        {
            var input = "lol and OMG".ToCharArray();
            Console.WriteLine(new string(input));
            ReverseWords.Reverse(input);
            Console.WriteLine(new string(input));                        
        }

        private static void ExecReverseString()
        {
            var expected = "EDCBA".ToCharArray();
            var actual = "ABCDE".ToCharArray();
            Console.WriteLine(actual);
            ReverseString.Reverse(actual);
            Console.WriteLine(actual);           
        }

        private static void ExecMeetingRangeProblem()
        {
            var meetings = new List<Meeting>();
            //Test case 1:
            /*meetings.Add(new Meeting(0,1));
            meetings.Add(new Meeting(3,5));
            meetings.Add(new Meeting(4,8));
            meetings.Add(new Meeting(10,12));
            meetings.Add(new Meeting(9,10));*/
            //Test case 2:
            /*meetings.Add(new Meeting(1,3));
            meetings.Add(new Meeting(4,8));*/
            //Test case 3:
            meetings.Add(new Meeting(1,4));
            meetings.Add(new Meeting(2,5));
            meetings.Add(new Meeting(5,8));
            var result = MeetingRange.MergeRanges(meetings);
            foreach(var meeting in result)
            {
                Console.WriteLine($"({meeting.StartTime},{meeting.EndTime})");
            }
        }

        private static void ExecSelectionSort(int[] inputArray)
        {
            Console.WriteLine("<--Selection Sort Algorithm-->");
            var sortArray = new  SelectionSort();
            PrintArray(inputArray, "Input:");
            int[] output = sortArray.Sort(inputArray);
            PrintArray(output,"Result:");
        }

        private static void ExecBubbleSort(int[] inputArray)
        {
            Console.WriteLine("<--Bubble Sort Algorithm-->");
            var sortArray = new  SelectionSort();
            PrintArray(inputArray, "Input:");
            int[] output = sortArray.Sort(inputArray);
            PrintArray(output,"Result:");
        }

        private static void ExecMergeSort(int[] inputArray)
        {
            Console.WriteLine("<--Merge Sort Algorithm-->");
            var sortArray = new  MergeSort();
            PrintArray(inputArray, "MergeSort Input:");
            int[] output = sortArray.Sort(inputArray);
            PrintArray(output,"MergeSort Result:");
        }


        private static void ExecCircularQueue(int[] inputArray)
        {
            Console.WriteLine("<--Circular Queue data structure-->");
            CircularQueue circularQueue = new CircularQueue(3); // set the size to be 3
            Console.WriteLine($"EnQueue 1:{circularQueue.enQueue(1)}");  // return true
            Console.WriteLine($"EnQueue 2:{circularQueue.enQueue(2)}");  // return true
            Console.WriteLine($"EnQueue 3:{circularQueue.enQueue(3)}");  // return true
            Console.WriteLine($"EnQueue 4:{circularQueue.enQueue(4)}");  // return false, the queue is full
            Console.WriteLine($"Rear:{circularQueue.Rear()}");  // return 3
            Console.WriteLine($"Is Queue full:{circularQueue.isFull()}");  // return true
            Console.WriteLine($"DeQueue:{circularQueue.deQueue()}");  // return true
            Console.WriteLine($"EnQueue 4:{circularQueue.enQueue(4)}");  // return true
            Console.WriteLine($"Rear:{circularQueue.Rear()}");  // return 4
            Console.WriteLine("Current Queue status:");
            PrintArray(circularQueue.GetAll(), "Current Queue Status:");
            Console.WriteLine($"DeQueue:{circularQueue.deQueue()}");  // return true
            Console.WriteLine($"EnQueue 5:{circularQueue.enQueue(5)}");  // return true
            PrintArray(circularQueue.GetAll(), "Current Queue Status:");
        }

        private static void PrintArray(int[] arr, string heder)
        {
            Console.WriteLine(heder);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        
        private static void ExecQueueDs(int[] inputArray)
        {
             var queueDs = new QueueDs();
             foreach(var item in inputArray)
             {
                 //Add item in array - Q first in
                 queueDs.enQueue(item);
             }             
             Console.WriteLine($"Item deQueued:{queueDs.deQueue()}");
             int addNewItem = 100;
             Console.WriteLine($"Item enQueued:{addNewItem.ToString()}");
             queueDs.enQueue(100);
             var itemInQ = queueDs.GetAllItems();

             //Print the output
             foreach(var item in itemInQ)
             {                 
                Console.WriteLine(item);
             }    

             //queueDs.enQueue()
        }
    }
}
