var triangular = LoadTriangleNumbers();

var characterMap = LoadCharacterMap();

using var reader = new StreamReader("0042_words.txt");

int countOfTriangles = 0;
string line = reader.ReadToEnd();
var words = line.Split(',');
foreach (var quotedWord in words)
{
    var word = quotedWord.Substring(1, quotedWord.Length - 2);
    int charCount = 0;
    foreach (var c in word)
        charCount += characterMap[c];
    if(triangular.Contains(charCount)) countOfTriangles += 1;
}

Console.WriteLine($"Triangle words: {countOfTriangles}");

static HashSet<int> LoadTriangleNumbers()
{
    var triangular = new HashSet<int>();
    for (var n = 1; n <= 500; n++)
    {
        var tn = n * (n + 1) / 2;
        triangular.Add(tn);
    }
    return triangular;
}

static Dictionary<char, int> LoadCharacterMap()
{
    var characterMap = new Dictionary<char, int>();
    for (var c = 'A'; c <= 'Z'; c++)
    {
        characterMap.Add(c, c - 64);
    }
    return characterMap;
}