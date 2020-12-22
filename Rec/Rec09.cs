using System;

namespace Rec
{
    public class Rec09
    {
        public void PrintCharsUntiilDollarSignBackwards(string s)
        {
            if (s.Length <= 0)
                return;
            if (s[0] == '$')
                return;
            PrintCharsUntiilDollarSignBackwards(s.Substring(1));
            Console.WriteLine(s[0]);     
        }
    }
}
