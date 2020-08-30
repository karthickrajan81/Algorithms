using System;
namespace Algorithms.Problems
{
    public class StockPrices
    {
        public static int GetMaxProfit(int[] stockPrices)
        {
            if(stockPrices.Length <= 1)
            {
                return 0;
            }
            // Calculate the max profit
            int minVal = stockPrices[0];
            int profit = stockPrices[1] - stockPrices[0];
            int index = 1;
            while(index < stockPrices.Length)
            {
                var stockVal = stockPrices[index];
                var currentprofit = stockVal  - minVal;
                minVal = Math.Min(minVal,stockVal);
                profit = Math.Max(profit,currentprofit);
                index++;
            }            
            return profit;
        }

    }
}