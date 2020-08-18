using System;

namespace Algorithms.Problems
{
    public class ReverseString
    {
            public static void Reverse(char[] arrayOfChars)
            {
                // Reverse input array of characters in place
                if(arrayOfChars.Length <= 1)
                {
                    return;
                }
                int lastIndex = arrayOfChars.Length - 1;
                int mid = arrayOfChars.Length/2;
                for(int i=0;i<mid;i++)
                {
                    var swapIndex = lastIndex - i;
                    var temp = arrayOfChars[i];
                    arrayOfChars[i] = arrayOfChars[swapIndex];
                    arrayOfChars[swapIndex] = temp;
                }
            }
    }
}