namespace Rec
{
    public class Rec27
    {
        public bool IsNumberFitsNumBase(int numBase, int num)
        {
            if (num < 0)
                return false;
            if (num < 10)
                return num < numBase;
            if (num % 10 < numBase)
                return IsNumberFitsNumBase(numBase, num / 10);
            else return false;
        }
    }
}
