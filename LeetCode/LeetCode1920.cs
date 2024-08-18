namespace LeetCode;

public static class LeetCode1920
{
    public static int[] BuildArray(int[] nums)
    {
        Span<int> output = stackalloc int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            output[i] = nums[nums[i]];
        }

        return output.ToArray();
    }
}