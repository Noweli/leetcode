using System.Text;

namespace LeetCode;

public static class LeetCode3110
{
    public static int ScoreOfString(string s)
    {
        var sum = 0;
        var asciiBytes = Encoding.ASCII.GetBytes(s);
        for (var i = 0; i < asciiBytes.Length-1; i++)
        {
            sum += Math.Abs(asciiBytes[i] - asciiBytes[i + 1]);
        }

        return sum;
    }
}