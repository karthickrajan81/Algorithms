using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class FirstComeFirstServe
    {
        public static bool IsFirstComeFirstServed(int[] takeOutOrders, int[] dineInOrders, int[] servedOrders)
        {
            // Check if we're serving orders first-come, first-served
            if(takeOutOrders.Length == 0 || dineInOrders.Length == 0)
            {
                return true;
            }
            if(takeOutOrders.Length + dineInOrders.Length != servedOrders.Length)
            {
                return false;
            }
            int inPointer = 0;
            int outPointer = 0;
            
            for(int i=0;i<servedOrders.Length;i++)
            {
                if(inPointer < dineInOrders.Length && servedOrders[i]==dineInOrders[inPointer])
                {
                    inPointer++;
                }
                else if(outPointer < takeOutOrders.Length && servedOrders[i]==takeOutOrders[outPointer])
                {
                    outPointer++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}