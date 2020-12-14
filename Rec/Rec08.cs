using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec08
    {
        public int RunRec(int[][] arr, int num, int indX, int indY)
        {

            if (indY == arr[0].Length)
                return RunRec(arr, num, indX + 1, 0);
            else if (indX == arr.Length)
                return 0;

            if (arr[indX][indY] == num)
                return RunRec(arr, num, indX, indY + 1) + 1;
            return
            RunRec(arr, num, indX, indY + 1);
        }
    }
}
