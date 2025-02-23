using Solver;

List<long> pentagonals = [0];
HashSet<long> pentagonalsLookup = [];

for (int n = 1; n <= 2_500_000; n += 1)
{
    long p = ((long)n).ToPentagonal();
    pentagonals.Add(p);
    pentagonalsLookup.Add(p);
}

for (int k = 2; k < pentagonals.Count; k += 1)
{
    long pk = pentagonals[k];

    for(var j = k - 1; j > 0; j -= 1)
    {
        long d;
        var pj = pentagonals[j];
        Console.CursorLeft = 0;
        Console.Write($"({pj}, {pk})");
        if (pentagonalsLookup.Contains(pj + pk) && pentagonalsLookup.Contains(d = pk - pj))
        {
            Console.WriteLine();
            Console.WriteLine(d);
            break;
        }
    }
    
}

