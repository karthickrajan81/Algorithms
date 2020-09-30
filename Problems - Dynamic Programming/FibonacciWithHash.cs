using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class FibonacciWithHash
    {
        public static int Fib(int n)
        {
            // Compute the nth Fibonacci number
            if(n < 0)
            {
                throw new ArgumentException();
            }
            var resultHash = new Dictionary<int,int>();
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
                prev1 = Fib(n-1);
                resultHash.Add(n-1,prev1);
            }
            
            var prev2 = 0;
            if(resultHash.ContainsKey(n-2))
            {
                prev2 = resultHash[n-2];
            }
            else
            {
                prev2 = Fib(n-2);
                resultHash.Add(n-2,prev2);
            }
            
            return prev1+prev2;
        }
    }
}