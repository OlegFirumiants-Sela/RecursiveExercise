namespace Rec
{
    public class Rec01
    {
        public int Factorial(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return n;
            return n * Factorial(n - 1);
        }
    }
}
