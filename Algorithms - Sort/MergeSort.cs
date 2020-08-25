using System;
using Algorithms.Helper;

namespace Algorithms.Sorting
{
public class MergeSort{

    public int[] Sort(int[] inputArray)
    {
        if(inputArray.Length < 2)
        {
            return inputArray;
        }
        var arrLength = inputArray.Length;   

        //1.Validate input
        if(null == inputArray || inputArray.Length == 0)
        {
            new ArgumentException();
        }

        int[] outputArray = new int[arrLength];        

        //2. Split the array
        var midValue = inputArray.Length/2;    

        var leftArray = Sort(ArrayHelper.CreateSubArray(inputArray,0,midValue));
        var rightArray = Sort(ArrayHelper.CreateSubArray(inputArray,midValue,inputArray.Length));

        int rightArrayPointer = 0;
        int leftArrayPointer = 0;
        for(int i=0;i<inputArray.Length;i++)
        {
            if(leftArrayPointer < leftArray.Length 
                && (rightArrayPointer >= rightArray.Length
                || leftArray[leftArrayPointer] < rightArray[rightArrayPointer]))
            {
                outputArray[i] = leftArray[leftArrayPointer];
                leftArrayPointer++;
            }
            else
            {
                outputArray[i] = rightArray[rightArrayPointer];
                rightArrayPointer++;
            }
        }

        return outputArray;
    }
}
}