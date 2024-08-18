namespace LeetCode;

public static class LeetCode35
{
    public static int SearchInsert(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target)
            {
                return i;
            }

            if (i < nums.Length - 1 && nums[i+1] > target)
            {
                return i+1;
            }
        }

        return nums.Length;
    }
}