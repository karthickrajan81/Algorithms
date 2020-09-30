using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class FibonacciWithHash
    {

        public static int FibUsingBottomUp(int n)
        {
            // Compute the nth Fibonacci number
            if(n < 0)
            {
                throw new ArgumentException();
            }
            if(n == 0)
            {
                return 0;
            }
            if(n == 1 || n == 2)
            {
                return 1;
            }
            var prev1 = 0;            
            var prev2 = 1;
            var result = 0;
            int count = 1;            
            while(count < n)
            {
                result = prev1+prev2;
                prev1 = prev2;
                prev2 = result;
                count++;
            }
            
            return result;
        }
        static Dictionary<int,int> resultHash = new Dictionary<int,int>();
        public static int FibUsingMemoization(int n)
        {
            // Compute the nth Fibonacci number
            if(n < 0)
            {
                throw new ArgumentException();
            }
            if(n == 0)
            {
                return 0;
            }
            if(n == 1 || n == 2)
            {
                return 1;
            }
            var prev1 = 0;
            if(resultHash.ContainsKey(n-1))
            {
                prev1 = resultHash[n-1];
            }
            else
            {
                prev1 = FibUsingMemoization(n-1);
                resultHash.Add(n-1,prev1);
            }
            
            var prev2 = 0;
            if(resultHash.ContainsKey(n-2))
            {
                prev2 = resultHash[n-2];
            }
            else
            {
                prev2 = FibUsingMemoization(n-2);
                resultHash.Add(n-2,prev2);
            }
            
            return prev1+prev2;
        }
    }
}