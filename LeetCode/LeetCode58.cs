namespace LeetCode;

public static class LeetCode58
{
    public static int LengthOfLastWord(string s) {
        var length = s.Trim().Split(' ').Last().Length;

        return length;
    }
}