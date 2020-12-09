using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec13
    {

        public void RunRec(int n)
        {
            List<int> arr = new List<int>();
            RunRec(arr, 1, n);
        }
        private void RunRec(List<int> arr, int i, int n)
        {
            if (n == 0)
                printList(arr);

            for (int j = i; j <= n; j++)
            {
                arr.Add(j);

                RunRec(arr, j, n - j);

                arr.RemoveAt(arr.Count - 1);
            }
        }
        
        private void printList(List<int> arr)
        {
            if (arr.Count != 1)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
