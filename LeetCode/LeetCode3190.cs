namespace LeetCode;

public static class LeetCode3190
{
    public static int MinimumOperationsCount(int[] nums)
    {
        return nums.Count(num => num % 3 != 0);
    }

    public static int MinimumOperationsWhere(int[] nums)
    {
        return nums
            .Where(num => num % 3 != 0)
            .ToArray()
            .Length;
    }

    public static int MinimumOperationsAsParallel(int[] nums)
    {
        return nums
            .AsParallel()
            .Where(num => num % 3 != 0)
            .ToArray()
            .Length;
    }
}