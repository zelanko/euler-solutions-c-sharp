using Problem_43;

long sum = 0;
var myTop = Console.CursorTop;

for(long i = 9_876_543_210; i > 999_999_999; i -= 1)
{
    Console.CursorTop = myTop;
    Console.CursorLeft = 0;
    if (i % 5_000_000 == 0 ) Console.WriteLine(i);
    var s = Convert.ToString(i);
    if (! s.IsPandigital()) continue;
    if (! s.IsSubstringDivisible()) continue;

    sum += i;
    Console.CursorTop = myTop + 1;
    Console.CursorLeft = 0;
    Console.WriteLine($"Last Found: {i}\nRunning Sum: {sum}");
}
Console.CursorTop = myTop + 2;
Console.CursorLeft = 0;
Console.WriteLine($"Final Answer: {sum}");