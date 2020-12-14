﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec28
    {
        public int RunRec(int[] arr, int head, int tail, int value)
        {
            int middle = (head + tail) / 2;
            if (arr[middle] == value)
                return middle;
            else if (head >= tail)
                return -1;
            else if (value < arr[middle])
                return RunRec(arr, head, middle - 1, value);
            else
                return RunRec(arr, middle + 1, tail, value);
        }

    }
}
