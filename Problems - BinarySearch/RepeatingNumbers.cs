using System;
using System.Collections.Generic;
using Algorithms.Helper;
using Algorithms.Search;
using Algorithms.Sorting;

namespace Algorithms.Problems
{

    public class RepeatingNumbers
    {
        public static int FindRepeat(int[] numbers)
        {
            // Find a number that appears more than once
            //Brute Force approach O(1) Space complexity O(n^2) time complexity
            /*var index = 0;
            while (index < numbers.Length)
            {
                var currentValue = numbers[index];
                
                for(int i=0;i < numbers.Length;i++)
                {
                    if(i != index && numbers[i] == currentValue)
                    {
                        return currentValue;
                    }
                }
                index++;
            }*/
            
            //Using Hash approach O(n) space and O(n) time complexity
            /*var hash = new HashSet<int>();
            var index = 0;
            while (index < numbers.Length)
            {
                var currentValue = numbers[index];
                if(hash.Contains(currentValue))
                {
                    return currentValue;
                }
                else
                {
                    hash.Add(currentValue);
                }
                index++;
            }*/
            
            //In place Merge Sort with O(1) space and O(nlogn) time complexity
            InPlaceMergeSort.Sort(numbers,0,numbers.Length-1);
            for(int i=0;i<numbers.Length -1;i++)
            {
                if(numbers[i] == numbers[i+1])
                {
                    return numbers[i];
                }
            }
            return 0;
        }        
    }    
}