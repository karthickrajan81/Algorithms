using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SameMovieLength
    {
    public static bool CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
    {
        // Determine if two movies add up to the flight length
        //var mLenDict = new Dictionary<int,List<int>>();
        var hashKeys = new HashSet<int>();
        for(int i=0;i<movieLengths.Length;i++)
        {
            //Brute force
           /* for(int j=i+1;j<movieLengths.Length;j++)
            {
                if(movieLengths[i] + movieLengths[j] == flightLength)
                {
                    return true;
                }
            }*/
            var val = movieLengths[i];
            var diff = flightLength - val;
            if(hashKeys.Contains(diff))
            {
                return true;
            }
            else
            {
                hashKeys.Add(val);
            }

           /*var val = movieLengths[i];
            if(mLenDict.ContainsKey(val))
            {
                mLenDict[val].Add(i);                
            }
            else
            {
                var lst = new List<int>();
                lst.Add(i);
                mLenDict.Add(val,lst);
            }*/
            //var val = fligthLength - movieLengths[i];
            
        }
        //Solved with Dictionary
        /*for(int i=0;i<movieLengths.Length;i++)
        {
           var val = flightLength - movieLengths[i];

           if(mLenDict.ContainsKey(val))
           {
            if(val != movieLengths[i] || mLenDict[val].Count > 1)
               return true;
           }
        }*/
        return false;
    }

    }
}