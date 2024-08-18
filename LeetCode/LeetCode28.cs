namespace LeetCode;

public static class LeetCode28
{
    public static int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle, StringComparison.InvariantCulture); 
    }
}