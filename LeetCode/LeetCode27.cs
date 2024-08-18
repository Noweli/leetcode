namespace LeetCode;

public static class LeetCode27
{
    public static int RemoveElement(int[] nums, int val)
    {
        nums = nums.Where(v => v != val).ToArray();
        return nums.Length;
    }
}