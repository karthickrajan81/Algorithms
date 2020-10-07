using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class GetAllCombinationOfChange
    {
        //input : conis: {1,2,3} amount: 4
        public static int GetNumberOfPossibilities(int input, int[] changeAvailable, int changeIndex = 0)
        {
            if(input == 0)
            {
                return 1;
            }
            if(input < 0 || changeAvailable.Length == 0 || changeIndex == changeAvailable.Length)
            {
                return 0;
            }
           
            var remaining = input;
            int currentCoin = changeAvailable[changeIndex];
            int numberOfPossibilities=0;
            while(remaining >= 0)
            {               
                numberOfPossibilities += GetNumberOfPossibilities(remaining,changeAvailable,changeIndex+1);
                remaining-=currentCoin;
                
            }
            return numberOfPossibilities;
        }

    }
}