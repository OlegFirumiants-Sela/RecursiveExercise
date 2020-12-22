using System;

namespace Rec
{
    public class Rec31
    {
        public int MinSub { get; set; }
        public int MinimalSubtraction(int[] arr)
        {
            MinSub = int.MaxValue;
            var sorted =MinimalSubtraction(arr, 0, arr.Length - 1);
            Print(sorted);
            return MinSub;
        }

        private int[] MinimalSubtraction(int[] arr, int iLeft, int iRight)
        {
            if (iRight - iLeft == 0)
                return new int[1] { arr[iLeft] };
            if (iRight - iLeft == 1)
            {
                UpdateMinSub(arr[iLeft], arr[iRight]);
                return arr[iLeft] <= arr[iRight] ? new int[2] { arr[iLeft], arr[iRight] } : new int[2] { arr[iRight], arr[iLeft] };
            }

            var mid = (iLeft + iRight) / 2;
            // sort left
            var arrL = MinimalSubtraction(arr, iLeft, mid);
            // sort right
            var arrR = MinimalSubtraction(arr, mid + 1, iRight);
            // merge
            return Merge(arrL, arrR);
        }

        private int[] Merge(int[] arrL, int[] arrR)
        {
            var mergedArr = new int[arrL.Length + arrR.Length];
            int i = 0, j = 0;
            while (i + j < mergedArr.Length)
            {
                if (i < arrL.Length && j < arrR.Length)
                    if (arrL[i] <= arrR[j])
                    {
                        UpdateMinSub(arrL[i], arrR[j]);
                        mergedArr[i + j] = arrL[i];
                        i++;
                    }
                    else
                    {
                        UpdateMinSub(arrL[i], arrR[j]);
                        mergedArr[i + j] = arrR[j];
                        j++;
                    }
                else if (i == arrL.Length)
                {
                    mergedArr[i + j] = arrR[j];
                    j++;
                }
                else
                {
                    mergedArr[i + j] = arrL[i];
                    i++;
                }
            }
            return mergedArr;
        }

        private void UpdateMinSub(int a, int b)
        {
            if (MinSub > Math.Abs(a - b))
                MinSub = Math.Abs(a - b);
        }

        private void Print(int[] a)
        {
            foreach (var i in a)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
