using System;
using System.Collections.Generic;
/* Each round, players receive a score between 0 and 100, which you use to rank them from highest to lowest. 
So far you're using an algorithm that sorts in O(n\lg{n})O(nlgn) time, 
but players are complaining that their rankings aren't updated fast enough. You need a faster sorting algorithm. */
namespace Algorithms.Problems
{
    public class SortUsingHash
    {
        public static int[] Sort(int[] input, int max)
        {
            var allScores = new Dictionary<int,int>();
            foreach(int item in input)
            {
                if(allScores.ContainsKey(item))
                {
                    allScores[item]++;
                }
                else
                {
                    allScores.Add(item,1);
                }

            }        

            var sortedArray = new int[input.Length];
            int pointer = 0;
            for(int score=max;score>=0;score--)
            {
                if(allScores.ContainsKey(score))
                {
                    int repeatedTimes = allScores[score];
                    while(repeatedTimes > 0)
                    {
                        sortedArray[pointer] = score;
                        repeatedTimes--;
                        pointer++;
                    }
                }
            }

            return sortedArray;
        }
        private Dictionary<int,int> GetAllPossibleScorRankposition(int max)
        {
            var allScores = new Dictionary<int,int>();
            var rank = 1;            
            while(rank <= max)
            {
                allScores.Add(max,rank);
                rank++;
                rank--;
            }
            return allScores;
        } 
     }
}