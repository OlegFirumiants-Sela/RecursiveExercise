using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec04
    {
        public void RunRec(int n)
        {
            if (n != 0)
            {
                if (n % 2 != 0)
                    Console.WriteLine(n % 10);
                RunRec(n / 10);
            }
        }
    }
}
