namespace LeetCode;

public static class LeetCode9
{
    public static bool IsPalindrome(int x) {
        var xToString = x.ToString();
        var reversed = xToString.Reverse();

        return xToString.SequenceEqual(reversed);
    }
}