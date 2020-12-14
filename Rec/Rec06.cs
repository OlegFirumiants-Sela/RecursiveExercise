using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec06
    {
        public bool RunRec(int[] arr)
        {
            if (arr.Length == 1)
                return true;
            if (arr[0] > arr[1])
                return false;
            else
                return RunRec(arr[1..arr.Length]);
        }
    }
}