namespace LeetCode;

public static class LeetCode5
{
    public static string LongestPalindrome(string s)
    {
        char[] longest = [s[0]];
        var longestLength = 1;
        var builder = new List<char>();

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                builder.Add(s[j]);

                if (!CheckIfPalindromic(builder) || builder.Count <= longestLength)
                {
                    continue;
                }

                longest = builder.ToArray();
                longestLength = longest.Length;

                break;
            }

            builder.Clear();
        }

        return string.Concat(longest);
    }

    private static bool CheckIfPalindromic(List<char> charList)
    {
        var reversed = charList
            .ToArray()
            .Reverse();

        return charList.SequenceEqual(reversed);
    }
}