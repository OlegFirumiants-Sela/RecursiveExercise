namespace Rec
{
    public class Rec23
    {
        public bool RunRec(int[][] arr)
        {
            return RunRec(arr, 0, 0);
        }
        private bool RunRec(int[][] arr, int index1, int index2)
        {
            if (index1 == arr.Length)
                return true;
            if (arr[index1][index2] != arr[index1][0] * arr[0][index2])
                return false;
            if (index2 == arr[index1].Length - 1)
            {
                index2 = 0;
                index1 = index1 + 1;
            }
            else
                index2 = index2 + 1;
            return RunRec(arr, index1, index2);
        }
    }
}
