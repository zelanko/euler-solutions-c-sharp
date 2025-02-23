public static class LongExtensions
{
    public static long ToTriangular(this long n) => n * (n + 1) / 2;
    public static long ToPentagonal(this long n) => n * (3 * n - 1) / 2;
    public static long ToHexagonal(this long n) => n * (2 * n - 1);
}