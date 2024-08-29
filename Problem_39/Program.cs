using System;

const double MAX_PARIMETER = 1000;

for (var p = 3; p <= MAX_PARIMETER; p += 1)
{
    var solutionCount = 0;
    for (var a = 1; a < p - 1; a += 1)
    {
        for (var b = 1; b < a; b += 1)
        {
            var c = CSideLength(a, b);
            
            if (a + b + c > p)
                break;
            if (!double.IsInteger(c) || a + b + c != p)
                continue;
            

            if (solutionCount == 0)
                Console.Write($"[{p}]: ");

            solutionCount += 1;
            Console.Write($"({a} {b} {c}), "); 
        }
    }
    if (solutionCount > 0) Console.WriteLine($"Count: {solutionCount}");
}

double CSideLength(double a, double b) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
