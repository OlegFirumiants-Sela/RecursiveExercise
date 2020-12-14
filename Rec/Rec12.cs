using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec12
    {
        public int RunRec(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber) 
                return firstNumber;
            else if (firstNumber > secondNumber) 
                return RunRec(firstNumber - secondNumber, firstNumber);
            else 
                return RunRec(secondNumber - firstNumber, firstNumber);
        }

    }
}
