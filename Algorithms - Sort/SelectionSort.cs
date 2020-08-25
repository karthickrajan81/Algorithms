using System;
namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] input)       
        {
            if(null == input || input.Length <= 0)
            {
                new ArgumentException();
            }            
            for(int i = 0;i<input.Length - 1; i++)
            {
                var min = i;
                for(int j= i+1;j<input.Length;j++)
                {
                    if(input[j] < input[min])
                    {                       
                        min = j;
                    }
                    var temp = input[i];
                    input[i] = input[min];
                    input[min] = temp;
                }
            }

            return input;
        }
    }
}