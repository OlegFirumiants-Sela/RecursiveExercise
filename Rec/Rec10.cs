using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec10
    {
        public int RunRec(int num, int x, int y)
        {
            string number = num.ToString();
            char[] numberArr = number.ToCharArray();
            return RunRec(number, numberArr, x.ToString()[0], y.ToString()[0], 0, 1);
        }
        private int RunRec(string num, char[] numArr, char x, char y, int i, int j)
        {
            if (j >= numArr.Length)
            {
                string res = new string(numArr);
                return int.Parse(res);
            }
            else
            {
                bool isOk = (i == 0 && j == 1) || (j == num.Length - 1 && i == num.Length - 2);
                bool isInRow = (num[i] == x && num[j] == y) || (num[i] == y && num[j] == x);
                if (isOk && isInRow)
                {
                    char tmp = numArr[i];
                    numArr[i] = numArr[j];
                    numArr[j] = tmp;
                }
                return RunRec(num, numArr, x, y, ++i, ++j);
            }
        }

    }
}
