using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec02
    {
        public void PrintArray(int[] arr)
        {
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            Console.WriteLine(arr[0]);
            PrintArray(arr[1..arr.Length]);
        }

        private static void RunRec(int[] arr, int index)
        {
            if (index != arr.Length - 1)
            {
                Console.WriteLine(arr[index]);
                RunRec(arr, index + 1);
            }
        }

    }
}
