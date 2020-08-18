using System;

namespace Algorithms.Problems
{
    public class MergeSortedArrays
    {
        public static int[] MergeArrays(int[] input1, int[] input2)
        {
            if(input1.Length == 0)
            {
                return input2;
            }
            if(input2.Length == 0)
            {
                return input1;
            }
            int tot = input1.Length + input2.Length;
            int[] output = new int[tot];
            int i = 0;
            int left = 0;
            int right = 0;
            while(i<tot)
            {
                if(left < input1.Length && (right >= input2.Length  || input1[left] < input2[right]))
                {
                    output[i]= input1[left];
                    left++;
                }
                else
                {
                    output[i] = input2[right];
                    right++;
                }
                i++;
            }
            return output;
        }
    }
}