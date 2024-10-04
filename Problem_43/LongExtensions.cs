using System.Linq;

namespace Problem_43;

public static class StringExtensions
{
    public static bool IsPandigital(this string str)
    {
        if (str.Length != 10) return false;

        const string pandigital = "0123456789";
        
        var strOrdered = str.Order().ToArray();

        for (var i = 0; i <= 9; i += 1)
        {
            if (strOrdered[i] != pandigital[i]) return false;
        }

        return true;
    }

    public static bool IsSubstringDivisible(this string str)
    {
        int i = Convert.ToInt32(str[1..4]);
        if (i % 2 != 0) return false;
        i = Convert.ToInt32(str[2..5]);
        if (i % 3 != 0) return false;
        i = Convert.ToInt32(str[3..6]);
        if (i % 5 != 0) return false;
        i = Convert.ToInt32(str[4..7]);
        if (i % 7 != 0) return false;
        i = Convert.ToInt32(str[5..8]);
        if (i % 11 != 0) return false;
        i = Convert.ToInt32(str[6..9]);
        if (i % 13 != 0) return false;
        i = Convert.ToInt32(str[7..10]);
        if (i % 17 != 0) return false;
        return true;    
    }
} 