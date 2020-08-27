using System;
/*Write an efficient method that checks whether any permutation
of an input string is a palindrome.*/
namespace Algorithms.Problems
{
    public class Palindrome
    {
        public static bool IsPalindrome(char[] charArray)
        {
            var len = charArray.Length/2;
            var lastIndex = charArray.Length - 1;            
            int index = 0;
            while(index<len)
            {
                var s = lastIndex - index;                
                if(charArray[index] != charArray[s])
                {
                    return false;
                }
                index++;
            }
            return index == len;            
        }
    }
}