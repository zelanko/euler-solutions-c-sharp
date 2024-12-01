namespace Problem_44;

public static class LongExtensions
{
    public static long ToPentagonal(this int n) => (long)n * (3 * n - 1)/ 2;    
}