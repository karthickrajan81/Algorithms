using System;
using System.Text;
using System.Collections.Generic;
public class WordCollection
    {
        private Dictionary<string, int> _wordsToCounts = new Dictionary<string, int>();

        public IDictionary<string, int> WordsToCounts
        {
            get { return _wordsToCounts; }
        }

        public WordCollection(string inputString)
        {
            PopulateWordsToCounts(inputString);
        }

        private void PopulateWordsToCounts(string inputString)
        {
            // Count the frequency of each word
            char[] letters = inputString.ToCharArray();
            var start = -1;
            var substLen = 0;            
            for(int index=0;index <  letters.Length;index++)
            {
                var val = letters[index];
                if(!IsSeperator(val))
                {
                    if(start == -1 && val != '-')
                    {
                        start = index;
                    }
                    if(start >= 0)
                    {
                        if(IsCharAllowedInWord(val))
                        {
                            substLen++;
                        }
                        if(index == letters.Length -1)               
                        {
                            AddToDictionary(WordsToCounts,inputString,start,substLen);
                        }
                    }
                }
                else if(substLen > 0)
                {
                    AddToDictionary(WordsToCounts,inputString,start,substLen);
                    start = -1;
                    substLen = 0;
                }
            }
        }

        private static bool IsCharAllowedInWord(char val)
        {
            return char.IsLetter(val) || val == '-' || val == '\'';
        }

        private static bool IsSeperator(char val)
        {
            return char.IsSeparator(val) || val == '.';
        }

        private static void AddToDictionary(IDictionary<string,int> WordsToCounts,string sentence, int start, int substLen)
        {
            var wordStr = sentence.Substring(start, substLen);
            if(WordsToCounts.ContainsKey(wordStr))
            {
                WordsToCounts[wordStr]++;
            }
            else
            {
                WordsToCounts.Add(wordStr,1);
            }
        }
    }
