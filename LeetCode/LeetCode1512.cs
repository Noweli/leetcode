namespace LeetCode;

public static class LeetCode1512
{
    public static int NumIdenticalPairs(int[] nums)
    {
        var goodPairs = 0;
        List<Task> tasks = [];

        tasks.AddRange(nums.Select((_, i) => i)
            .Select(currentIndex => Task.Run(() =>
            {
                for (var j = currentIndex + 1; j < nums.Length; j++)
                {
                    if (nums[currentIndex] == nums[j])
                    {
                        goodPairs++;
                    }
                }
            })));

        Task.WhenAll(tasks).Wait();

        return goodPairs;
    }
}