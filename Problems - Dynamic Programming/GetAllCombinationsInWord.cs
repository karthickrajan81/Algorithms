using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class GetAllCombinationsInWord
    {
        public static HashSet<string> GetCombinations(string input)
        {
            if(string.IsNullOrEmpty(input) || input.Length <= 1)
            {
                return new HashSet<string> {input};
            }

            var output = new HashSet<string>();
            var lastIndex = input.Length - 1;    
            var lastLetter = input[lastIndex].ToString();
            var excludeLastCharInput = input.Substring(0,lastIndex);
            var currentCombinations = GetCombinations(excludeLastCharInput);
            int index = 0;

            while(index < input.Length)
            {               
               foreach(var item in currentCombinations)
               {
                   var combination = item.Insert(index,lastLetter);
                   output.Add(combination);
               }
               index++;
            }
            return output;
        }
    }
}