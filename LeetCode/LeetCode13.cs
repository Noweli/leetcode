namespace LeetCode;

public static class LeetCode13
{
    private static readonly Dictionary<char, int> RomanDictionary = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static int RomanToInt(string s) {
        var romanConverted = s.Select(roman => RomanDictionary[roman]).ToArray();

        if (romanConverted.Length == 1)
        {
            return romanConverted[0];
        }
        
        var result = 0;
        for (var i = 1; i < romanConverted.Length;)
        {
            if (romanConverted[i] > romanConverted[i - 1])
            {
                result += romanConverted[i] - romanConverted[i - 1];
                i += 2;
            }
            else
            {
                result += romanConverted[i - 1];
                i++;
            }

            if (romanConverted.Length == i)
            {
                result += romanConverted[i-1];
            }
        }

        return result;
    }
}