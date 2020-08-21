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
            var inDict = new Dictionary<int,int>();
            for(int index = 0; index < takeOutOrders.Length; index++)
            {
                inDict.Add(takeOutOrders[index],index);
            }
            var outDict = new Dictionary<int,int>();
            for(int index = 0; index < dineInOrders.Length; index++)
            {
                outDict.Add(dineInOrders[index],index);
            }
            int inPointer = 0;
            int outPointer = 0;
            
            for(int i=0;i<servedOrders.Length;i++)
            {
                var o = servedOrders[i];
                if(inDict.ContainsKey(o))
                {
                    if(inPointer <= inDict[o])
                    {
                        inPointer = inDict[o];
                        inPointer++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(outDict.ContainsKey(o))
                {
                    if(outPointer <= outDict[o])
                    {
                        outPointer = outDict[o];
                        outPointer++;
                    }
                    else
                    {
                        return false;
                    }
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