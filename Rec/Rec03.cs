namespace Rec
{
    class Rec03
    {
        public int RunRec(int n)
        {
            if (n < 0)
                return -1;
            if (n < 10)
                return n;
            return n % 10 * RunRec(n / 10);
        }

    }
}
