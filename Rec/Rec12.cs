using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec12
    {
        public int GetGCD(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber) 
                return firstNumber;
            else if (firstNumber > secondNumber) 
                return GetGCD(firstNumber - secondNumber, firstNumber);
            else 
                return GetGCD(secondNumber - firstNumber, firstNumber);
        }

    }
}
