using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec26
    {
        public bool CheckDiagonalSum(int[][] arr, int i, int s)
        {
            s += arr[i][i];
            s += arr[i][arr.Length - 1];
            s += arr[arr.Length - 1][i];

            if (i == arr.Length - 1)
            {
                if (arr[arr.Length - 1][arr.Length - 1] == s)
                    return true;
                return false;
            }
            return CheckDiagonalSum(arr, i + 1, s);
        }
    }
}
