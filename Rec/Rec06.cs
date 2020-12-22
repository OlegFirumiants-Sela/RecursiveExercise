using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec06
    {
        public bool IsArratSortedAscending(int[] arr)
        {
            if (arr.Length == 1)
                return true;
            if (arr[0] > arr[1])
                return false;
            else
                return IsArratSortedAscending(arr[1..arr.Length]);
        }
    }
}