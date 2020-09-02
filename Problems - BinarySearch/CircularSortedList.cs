using System;

namespace Algorithms.Problems
{
    /*I opened up a dictionary to a page in the middle and started flipping through, looking for words I didn't know. 
      I put each word I didn't know at increasing indices in a huge array I created in memory.
      When I reached the end of the dictionary, I started from the beginning and did the same thing until I reached the page I started at.
      Now I have an array of words that are mostly alphabetical, except they start somewhere in the middle of the alphabet, reach the end, 
      and then start from the beginning of the alphabet. In other words, this is an alphabetically ordered array that has been "rotated."*/
    public class CircularSortedList
    {       
        public static int FindRotationPoint(String[] words)
        {
            // Find the rotation point in the array
            //Linear search - Brute force apprach
                int next = 1;
                int prev = -1;     
                for(int i=0;i<words.Length;i++)
                {
                    if(i==0)
                    {
                        prev = words.Length -1;
                        next = i+1;
                    }
                    else if(i == words.Length -1)
                    {
                        next = 0;
                        prev = i-1;
                    }
                    else
                    {
                        next = i+1;
                        prev = i-1;
                    }

                    if(String.Compare(words[i], words[next], StringComparison.Ordinal) < 0
                    && String.Compare(words[i], words[prev], StringComparison.Ordinal) < 0)
                    {
                        return i;
                    }
                }
                //To do:  Binary Search approach
                return 0;            
        }
    }
}