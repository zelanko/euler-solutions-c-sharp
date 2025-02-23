// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

HashSet<long> pentagonalLookup = [];

HashSet<long> hexagonalLookup = [];

for (long n = 286; n < 2500000; n += 1)
{
    pentagonalLookup.Add(n.ToPentagonal());
    hexagonalLookup.Add(n.ToHexagonal());
    var triangularNumber = n.ToTriangular();
    if(pentagonalLookup.Contains(triangularNumber) && hexagonalLookup.Contains(triangularNumber))
    {
        Console.WriteLine(triangularNumber);
        break;
    }    
}