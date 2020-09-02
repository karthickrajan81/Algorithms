using System;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        public static bool Search(int[] sortedNums,int numToSearch)
        {            
            var start = 0;
            var end = sortedNums.Length -1 ;           
            while(start <= end)
            {               
                var mid =  (start+end)/2;                
                if(numToSearch == sortedNums[mid])
                {
                    return true;
                }
                if(numToSearch > sortedNums[mid])
                {
                    start = mid+1;                  
                }
                else
                {
                    end = mid-1;
                }
            }
            return false;
        }

        public static bool RecursiveSearch(int[] sortedNums,int start, int end,int numToSearch)
        { 
                if(start <= end)
                {
                    return false;
                }
                var mid = (start+end)/2;
                if(numToSearch == sortedNums[mid])
                {
                    return true;
                }
                if(numToSearch > sortedNums[mid])
                {
                    start = mid +1;
                    return RecursiveSearch(sortedNums,start,end,numToSearch);
                }
                else
                {
                    end = mid -1;
                    return RecursiveSearch(sortedNums,start,end,numToSearch);
                }           
        }
    }
}