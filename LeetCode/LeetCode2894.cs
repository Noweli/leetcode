namespace LeetCode;

public static class LeetCode2894
{
    public static int DifferenceOfSums(int n, int m)
    {
        var range = Enumerable.Range(1, n).ToArray();
        var divisible = range.Where(element => element % m == 0).ToArray();
        var notDivisibleSum = range.Except(divisible).Sum();

        return notDivisibleSum - divisible.Sum();
    }
}