using System;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        public static bool Search(int[] sortedNums,int numToSearch)
        {            
            var start = -1;
            var end = sortedNums.Length;           
            while(start+1 < end)
            {
                 var distance = end - start;
                 var mid = distance/2;
                 var pointer = mid+start;
                 if(pointer>= sortedNums.Length)
                 {
                     break;
                 }
                if(numToSearch == sortedNums[pointer])
                {
                    return true;
                }
                if(numToSearch > sortedNums[pointer])
                {
                    start = pointer;                  
                }
                else
                {
                    end = pointer;
                }
            }
            return false;
        }

        public static bool RecursiveSearch(int[] sortedNums,int start, int end,int numToSearch)
        { 
                if(!(start+1 <end))
                {
                    return false;
                }
                 var distance = end - start;
                 var mid = distance/2;
                 var pointer = mid+start;
                 if(pointer>= sortedNums.Length)
                 {
                     return false;
                 }
                if(numToSearch == sortedNums[pointer])
                {
                    return true;
                }
                if(numToSearch > sortedNums[pointer])
                {
                    return RecursiveSearch(sortedNums,pointer,end,numToSearch);
                }
                else
                {
                    return RecursiveSearch(sortedNums,start,pointer,numToSearch);
                }           
        }
    }
}