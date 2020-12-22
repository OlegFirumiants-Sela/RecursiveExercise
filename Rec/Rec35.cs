using System;
using System.Collections.Generic;

namespace Rec
{
    public class Rec35
    {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();
        public void PrinNotSharedValues(List<int> l1, List<int> l2)
        {
            foreach (var i in l2)
            {
                dict.Add(i, true);
            }
            foreach (var j in l1)
            {
                if (!dict.ContainsKey(j))
                    Console.Write($"{j} ");
            }
        }
    }
}
