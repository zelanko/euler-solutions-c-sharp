using System.Text;

var s = new StringBuilder();

for (var i = 1; i <= 1_000_000; i += 1)
{
    s.Append(i);
    if(s.Length > 1_000_000) break;
    Console.Write(i);
    Console.CursorLeft = 0;
}
Console.WriteLine();

System.Console.WriteLine($"{_(1) * _(10) * _(100) * _(1_000) * _(10_000) * _(100_000) * _(1_000_000)}");


int _(int i) => Convert.ToInt32(Convert.ToString(s[i - 1]));
