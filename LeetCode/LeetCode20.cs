namespace LeetCode;

public static class LeetCode20
{
    private static readonly char[] BracketsArray = ['(', '[', '{'];

    public static bool IsValid(string s)
    {
        var closingBrackets = new List<char>();
        foreach (var t in s)
        {
            if (BracketsArray.Contains(t))
            {
                closingBrackets.Add(GetReversedBrackets(t));
            }
            else
            {
                if (closingBrackets.Count == 0)
                {
                    return false;
                }

                if (t.Equals(closingBrackets.Last()))
                {
                    closingBrackets.RemoveAt(closingBrackets.Count - 1);
                }
                else
                {
                    return false;
                }
            }
        }

        return closingBrackets.Count == 0;
    }

    private static char GetReversedBrackets(char c)
    {
        return c switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            _ => char.MinValue
        };
    }
}