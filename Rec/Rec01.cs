namespace Rec
{
    public class Rec01
    {
        public int RunRec(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return n;
            return n * RunRec(n - 1);
        }
    }
}
