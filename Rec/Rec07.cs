using System;

namespace Rec
{
    public class Rec07
    {
        public int CountAppearancesOfNumInArray(int[] arr, int num)
        {
            if (arr.Length <= 0)
                return 0;
            if (arr.Length == 1)
                if (arr[0] == num)
                    return 1;
                else return 0;
            if (arr[0] == num)
                return 1 + CountAppearancesOfNumInArray(arr[1..arr.Length], num);
            else 
                return CountAppearancesOfNumInArray(arr[1..arr.Length], num);
        }
    }
}
