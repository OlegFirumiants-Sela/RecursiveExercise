using System;

namespace Rec
{
    public class Rec07
    {
        public int RunRec(int[] arr, int num)
        {
            if (arr.Length <= 0)
                return 0;
            if (arr.Length == 1)
                if (arr[arr.Length - 1] == num)
                    return 1;
                else return 0;
            if (arr[arr.Length - 1] == num)
                return 1 + RunRec(GetSubArray(arr), num);
            else 
                return RunRec(GetSubArray(arr), num);
        }

        private int[] GetSubArray(int[] arr)
        {
            Index iFrom = 0;
            Index iTo = arr.Length - 1;
            return arr[iFrom..iTo];
        }
    }
}
