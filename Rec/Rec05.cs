using System;

namespace Rec
{
    public class Rec05
    {
        public void PrintOddIndexesInArray(int[] arr)
        {
            if (arr.Length == 0)
                return;

            if (arr.Length % 2 != 0)
                Console.WriteLine(arr[arr.Length - 1]);

            PrintOddIndexesInArray(GetSubArray(arr));
        }
        private int[] GetSubArray(int[] arr)
        {
            Index iFrom = 0;
            Index iTo = arr.Length - 1;
            return arr[iFrom..iTo];
        }
    }
}
