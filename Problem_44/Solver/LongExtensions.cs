namespace Solver;

public static class LongExtensions
{
    public static long ToPentagonal(this long n) => n * (3 * n - 1) / 2;
}