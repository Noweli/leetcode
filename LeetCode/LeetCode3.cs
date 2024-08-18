namespace LeetCode;

public static class LeetCode3
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 1)
        {
            return 0;
        }

        var asSpan = s.AsSpan();
        Span<char> builder = stackalloc char[s.Length];
        builder[0] = asSpan[0];

        var longest = 1;
        var currentLongest = 1;
        var next = 1;
        var startIndex = 1;
        for (var i = startIndex; i < asSpan.Length; i++)
        {
            var current = asSpan[i];
            var previous = asSpan[i - 1];

            if (current != previous)
            {
                if (!builder.Contains(current))
                {
                    builder[next] = current;
                    currentLongest++;
                    next++;
                    
                    continue;
                }
            }

            longest = currentLongest > longest ? currentLongest : longest;
            currentLongest = 1;
            builder.Clear();
            builder[0] = asSpan[startIndex];
            next = 1;
            i = startIndex++;
        }

        return longest > currentLongest ? longest : currentLongest;
    }
}