using System;

namespace Rec
{
    public class Rec09
    {
        public void RunRec(string s)
        {
            if (s.Length <= 0)
                return;
            if (s[0] == '$')
                return;
            RunRec(s.Substring(1));
            Console.WriteLine(s[0]);     
        }
    }
}
