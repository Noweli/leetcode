namespace LeetCode;

public static class LeetCode1929
{
    public static int[] GetConcatenation(int[] nums) {
        return nums.Concat(nums).ToArray();
    }
}