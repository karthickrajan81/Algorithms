using System;

namespace Algorithms.Helper
{
public static class ArrayHelper
{
    public static int[] CreateSubArray(int[] source, int begin, int end)
    {
        int len = end - begin;

        if(null == source || len < 0 || len > source.Length)
        {
            new InvalidOperationException();
        }

        int[] returnValue = new int[len];
        
        Array.Copy(source, begin, returnValue, 0, len);

        return returnValue;
    }
}
}