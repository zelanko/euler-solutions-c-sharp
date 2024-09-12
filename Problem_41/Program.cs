for(var n = 8_999_999; n >= 2_000; n -= 2)
{
    Console.CursorLeft = 0;
    Console.Write(n);
    
    if (IsPandigital(n) && IsPrime(n))
    {
        return;
    }
}

static bool IsPrime(long @int)
{
    if (@int <= 1) return false;
    if (@int == 2) return true;
    for (long i = 2;  i * i <= @int; i += 1)
    {
        if (@int % i == 0) return false;
    }
    return true;
}

static bool IsPandigital(long @int)
{
    char[] expected = ['1', '2', '3',  '4', '5', '6', '7', '8', '9'];
    var s = Convert.ToString(@int);
    var a = s!.Order().ToArray();

    for (var i = 1; i <= a.Length; i += 1)
    {
        char c = expected[i - 1];
        char c2 = a[i - 1];
        if (c2 != c) return false;
    }

    return true;
}