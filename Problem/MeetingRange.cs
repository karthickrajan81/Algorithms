 using System;
using System.Collections.Generic;
using Algorithms.Problems;

namespace Algorithms.Problems
{ 
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            var meeting = (Meeting)obj;
            return StartTime == meeting.StartTime && EndTime == meeting.EndTime;
        }

        public override int GetHashCode()
        {
            var result = 17;
            result = result * 31 + StartTime;
            result = result * 31 + EndTime;
            return result;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }

}

public class MeetingRange
{

    public static List<Meeting> MergeRanges(List<Meeting> meetings)
    {
        // Merge meeting ranges     
        var result = new List<Meeting>();
        //SortMeetings(meetings);
        for(int i= 0;i<meetings.Count;i++)
        {
            var startTime = meetings[i].StartTime;
            var endTime = meetings[i].EndTime;
            for(int j= i+1;j<meetings.Count;j++)
            {
                if(meetings[i].StartTime > meetings[j].StartTime)
                {
                    var temp = meetings[j];
                    meetings[j] = meetings[i];
                    meetings[i] = temp;
                    startTime = meetings[i].StartTime;
                    endTime = meetings[i].EndTime;
                }
                if(endTime >= meetings[j].StartTime)
                {
                    if(endTime < meetings[j].EndTime)
                    {
                        endTime = meetings[j].EndTime;
                    }
                    i++;
                }
                else
                {
                    break;
                }
            }
            var mergedMeeting = new Meeting(startTime,endTime);
            result.Add(mergedMeeting);
        }
        return result;  
    }

    public static List<Meeting> SortMeetings(List<Meeting> meetings)
    {
        for(int i= 0;i<meetings.Count -1;i++)
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
        }
        return meetings;
    }
}