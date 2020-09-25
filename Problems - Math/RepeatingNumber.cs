/*I have an array of n + 1n+1 numbers. 
Every number in the range 1..n1..n appears once except for one number that appears twice.
Write a method for finding the number that appears twice.*/
using System;

namespace Algorithms.Problems
{
    public class RepeatingNumber
    {
    public static int FindRepeat1(int[] numbers)
        {
            // Find the number that appears twice
            //var nPlusOneLen = numbers.Length;        
            var nLen = numbers.Length - 1;        
            //double sumOfnPlusOne = (Math.Pow(nPlusOneLen,2)+nPlusOneLen)/2;        
            int sumOfn = 0;        
            int.TryParse(((Math.Pow(nLen,2)+nLen)/2).ToString(), out sumOfn);        
            var result = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                result+= numbers[i];
            }        
            result -= sumOfn;
            return result;        
        }

        public static int FindRepeat(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                throw new ArgumentException();
            }
            for(int i=0;i<numbers.Length;i++)
            {
                var val = Math.Abs(numbers[i]);
                if(numbers[val] < 0)
                {
                    return val;
                }
                else
                {
                    numbers[val] *= -1;
                }
            }
            return -1;
        }
    }
}