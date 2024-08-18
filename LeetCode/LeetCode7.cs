namespace LeetCode;

public static class LeetCode7 {
    public static int Reverse(int x) {
        var isNegative = x < 0;

        var reversed = x.ToString().Reverse().ToList();

        if(isNegative)
        {
            reversed.RemoveAt(reversed.Count-1);
            reversed.Insert(0, '-');
        }

        var isParsable = int.TryParse(reversed.ToArray(), out var result);

        return isParsable ? result : 0;
    }
}