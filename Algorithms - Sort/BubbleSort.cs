using System;
namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        public int[] Sort(int[] input)
        {
            for(int i=0;i<input.Length;i++)
            {
                for(int j=0;j< input.Length-1;j++)
                {
                    if(input[i] > input[j])
                    {
                        var temp = input[j];
                        input[j] = input[i];
                        input[i]= temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return input;
        }
    }
}