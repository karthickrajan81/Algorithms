using System;
namespace Algorithms.Problems
{
    public class ProductsOfAllInts
    {
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] input)
        {
            var output = new int[input.Length];
            var allIntsBefore = new int[input.Length];
            var allIntsAfter = new int[input.Length];
            int prev = 1;
            for(int i=0;i<input.Length;i++)
            {
                allIntsBefore[i] = prev;
                prev *= input[i];
            }

            int next = 1;
            for(int i=input.Length - 1;i>=0;i--)
            {
                allIntsAfter[i] = next;
                next *= input[i];
            }

           for(int i=0;i<input.Length;i++)
            {
                output[i] = allIntsBefore[i] * allIntsAfter[i];               
            }

            return output;
        }        
    }
}