using Problem_44;

List<long> pentagonals = [0];

for (var n = 1; n <= 1_000_000; n += 1)
{
    var p = n.ToPentagonal();
    pentagonals.Add(p);
}

List<long> solutions = [];
long d;
for (var j = 1; j < pentagonals.Count; j += 1)
{
    var pj = pentagonals[j];
    Console.Write($"{pj},");
    for(var k = j + 1; k < pentagonals.Count; k += 1)
    {
        var pk = pentagonals[k]; 
        if (pentagonals.Contains(pj + pk) && pentagonals.Contains(d = pk - pj))
        {
            solutions.Add(Math.Abs(d));
            break;
        }
    }
    
}

if (solutions.Count == 0)
    Console.WriteLine("Did not find the qualifing pair. Probably increase the max value of n.");
else
    Console.WriteLine($"Found d to equal {solutions.Min()}");