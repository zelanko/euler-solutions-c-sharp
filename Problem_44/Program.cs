using Problem_44;

const string fileName = "TheFileIWrite";

using var stream = File.OpenWrite(fileName);
using var writer = new BinaryWriter(stream);

for (var n = 1; n < 13; n += 1)
{
    var p = n.ToPentagonal();
    writer.Write(p);
}
writer.Close();
stream.Close();
Console.WriteLine();
using var inStream = File.OpenRead(fileName);
using var reader = new BinaryReader(inStream);

int p1;
while(inStream.Position < inStream.Length)
{
    p1 = reader.ReadInt32();
    Console.Write($"{p1}, ");
}

reader.Close();
inStream.Close();
