using System;
namespace Algorithms.Problems
{   
    //Given an array of integers, find the highest product you can get from three of the integers. 
    public class FindHighest
    { 
        public static int HighestProductOf3(int[] input)
        {
            if(input.Length < 3)
            {
                throw new ArgumentException();
            }
            //int bestResult = input[0]*input[1]*input[2];
            //Brute Force O(n^3)
            /*for(int i=0;i<arrayOfInts.Length-2;i++)
            {
                for(int j=i+1;j<arrayOfInts.Length-1;j++)
                {
                    for(int k=j+1;k<arrayOfInts.Length;k++)
                    {
                        int currTimes = arrayOfInts[i]*arrayOfInts[j]*arrayOfInts[k];
                        bestResult = Math.Max(bestResult,currTimes);
                    }
                }
            }*/
            //Greedy approach - O(n)
            var high = Math.Max(input[0], input[1]);
            var low = Math.Min(input[0], input[1]);
            var highOf2 = input[0]*input[1];
            var lowOf2 = input[0]*input[1];
            var highOf3 = input[0]*input[1] * input[2];
            int index = 2;
            while(index < input.Length)
            {
                var currVal = input[index];
                highOf3 = Math.Max(Math.Max(highOf3,currVal * highOf2),currVal * lowOf2);
                highOf2 = Math.Max(Math.Max(highOf2, currVal * high), currVal * low);
                lowOf2 = Math.Min(Math.Min(lowOf2, currVal * high), currVal * low);
                high = Math.Max(high,currVal);
                low = Math.Min(high, currVal);
                index++;
            }
            return highOf3;
        }
    }
}