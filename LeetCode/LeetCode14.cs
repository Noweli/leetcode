namespace LeetCode;

public static class LeetCode14
{
    public static string LongestCommonPrefix(string[] strs) {
        var commonPrefix = string.Empty;
        foreach (var inputString in strs)
        {
            for (var j = 1; j <= inputString.Length; j++)
            {
                var prefix = inputString[..j];
                var matching = strs.Where(text => text.StartsWith(prefix)).ToArray();
                if (matching.Length == strs.Length)
                {
                    commonPrefix = prefix;
                }
            }
        }

        return commonPrefix;
    }
}