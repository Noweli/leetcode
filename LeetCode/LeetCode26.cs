namespace LeetCode;

public static class LeetCode26
{
    public static int RemoveDuplicates(int[] nums)
    {
        var i = 1;

        foreach (int n in nums)
        {
            if (nums[i - 1] != n)
            {
                nums[i++] = n;
            } 
        }

        return i;
    }
    
    public static int RemoveDuplicatesLinq(int[] nums)
    {
        return nums.Distinct().ToArray().Length;
    }
}