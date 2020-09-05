using System;
namespace Algorithms.Search
{
    public class InPlaceMergeSort
    {
        public static void Sort(int[] input, int left, int right)
        {        
            if(left < right)  
            {            
                int mid = (left+right)/2;
                Sort(input,left,mid);
                Sort(input,mid+1,right);
                Merge(input,left,mid,right);
            }
        }

        private static void Merge(int[] input, int start1, int end1, int arrayEnd)
        {
            int start2 = end1+1;

            if(input[end1] <= input[start2])
            {
                return;
            } 
            while(start1<=arrayEnd && start2 <= arrayEnd)
            {                
                if(input[start1] <= input[start2])
                {
                    start1++;
                }
                else
                {
                    int currentValue = input[start2];
                    int tempIndex = start2;
                    while(tempIndex != start1)
                    {
                        input[tempIndex] = input[tempIndex-1];
                        tempIndex--;
                    }
                    input[start1] = currentValue;
                    start2++;
                    start1++;
                    end1++;
                }
            }
        }
    }
}