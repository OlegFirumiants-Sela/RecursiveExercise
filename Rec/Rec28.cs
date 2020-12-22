using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec28
    {
        public int BinarySearch(int[] arr, int head, int tail, int value)
        {
            int middle = (head + tail) / 2;
            if (arr[middle] == value)
                return middle;
            else if (head >= tail)
                return -1;
            else if (value < arr[middle])
                return BinarySearch(arr, head, middle - 1, value);
            else
                return BinarySearch(arr, middle + 1, tail, value);
        }

    }
}
