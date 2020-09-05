using System;
using System.Collections.Generic;
using System.Linq;
/* Your company built an in-house calendar tool called HiCal. 
You want to add a feature to see the times in a day when everyone is available.
To do this, you’ll need to know when any team is having a meeting. 
In HiCal, a meeting is stored as an object of a Meeting class with integer properties StartTime and EndTime. 
These integers represent the number of 30-minute blocks past 9:00am. */
namespace Algorithms.Problems
{

    public class MergeMeetingsByMergeSort
    {
    //Solved Merge meeting problem in O(nlogn) using divide and conquer approach
    public static List<Meeting> MergeRanges(List<Meeting> meetings)
    {
        var sortedList = MergeSortMeetings(meetings); 
        // Merge meeting ranges     
        var result = new List<Meeting>{sortedList[0]};
        var index = 1;
        while(index < sortedList.Count)
        {
           var lastItem = result.Last();
           var item = sortedList[index];
           if(item.StartTime <= lastItem.EndTime)
           {
               lastItem.EndTime = Math.Max(lastItem.EndTime,item.EndTime);
           }
           else
           {
               result.Add(item);
           }
           index++;
        }
        return result;  
    }

        public static List<Meeting> MergeSortMeetings(List<Meeting> meetings)
        {
            /*for(int i= 0;i<meetings.Count -1;i++)
            {
                for(int j= i+1;j<meetings.Count;j++)
                {
                    if(meetings[i].StartTime > meetings[j].StartTime)
                    {
                        var temp = meetings[j];
                        meetings[j] = meetings[i];
                        meetings[i] = temp;
                    }              
                }
            } */
            if(null == meetings || meetings.Count < 2)
            {
                return meetings;
            }
            int start = 0;
            int end = meetings.Count;
            int mid = (start+end)/2;
            int rem = (start+end)%2;

            var leftList = MergeSortMeetings(meetings.GetRange(0,mid+rem));
            var rightList = MergeSortMeetings(meetings.GetRange(mid+rem,mid));

            var output = new List<Meeting>();

            int leftPointer = 0;
            int rightPointer = 0;
            for(int i=0;i<meetings.Count;i++)
            {
                if(leftPointer< leftList.Count && 
                    (rightPointer>= rightList.Count 
                        || leftList[leftPointer].StartTime <= rightList[rightPointer].StartTime))
                {
                    output.Add(leftList[leftPointer]);
                    leftPointer++;
                }
                else
                {
                    output.Add(rightList[rightPointer]);
                    rightPointer++;
                }
            }
            return output;
        }
    }
}