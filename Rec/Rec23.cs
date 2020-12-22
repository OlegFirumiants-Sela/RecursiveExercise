namespace Rec
{
    public class Rec23
    {
        public bool IsMultiplicationTable(int[][] arr)
        {
            return IsMultiplicationTable(arr, 0, 0);
        }
        private bool IsMultiplicationTable(int[][] arr, int index1, int index2)
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
            return IsMultiplicationTable(arr, index1, index2);
        }
    }
}
