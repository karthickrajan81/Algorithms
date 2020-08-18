using System;

namespace Algorithms.Problems
{
    public class ReverseWords
    {
        public static void Reverse(char[] message)
        {
            // Decode the message by reversing the words        
            var start = 0;
            SplitReverse(message, start, message.Length);
            int i = 0;
            while(i<message.Length)
            {
                var reverse = false;
                var end = i;
                if(message[i] == ' ')
                {                    
                    reverse = true;
                }
                else if(i == message.Length - 1)
                {
                    end = i+1;
                    reverse = true;
                }
                if(reverse)
                {
                    SplitReverse(message,start, end);
                    start = i+1;
                }

                i++;
            }
        }

        private static void SplitReverse(char[] message, int start, int end)
        {
            if(start >= 0 && end >= 0 && start < message.Length && end <= message.Length && end > start)
            {
                var mid = (start+end)/2;              
                while(start<mid)
                {                    
                    end--;  
                    var temp = message[end];
                    message[end] = message[start];
                    message[start] = temp;                    
                    start++;
                }
            }
        }
    }
}