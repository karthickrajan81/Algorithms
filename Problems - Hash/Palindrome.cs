using System;
using System.Collections.Generic;
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

        public static bool IsPalindromeOnAnyCombination(char[] charArray)
        {
           var dict = new HashSet<char>();
           for(int i=0;i<charArray.Length;i++)
           {
               var val = charArray[i];
               if(!dict.Contains(val))
               {
                   dict.Add(val);
               }
               else
               {
                  dict.Remove(val);
               }
           }
           return dict.Count <= 1;
        }
    }
}