namespace Rec
{
    class Rec03
    {
        public int MultiplyNumber(int n)
        {
            if (n < 0)
                return -1;
            if (n < 10)
                return n;
            return n % 10 * MultiplyNumber(n / 10);
        }

    }
}
