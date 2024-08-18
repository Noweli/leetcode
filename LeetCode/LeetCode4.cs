namespace LeetCode;

public static class LeetCode4
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
        {
            return GetMedian(nums2);
        }

        if (nums2.Length == 0)
        {
            return GetMedian(nums1);
        }

        var finalArray = nums1.Concat(nums2).Order();

        return GetMedian(finalArray.ToArray());
    }

    private static double GetMedian(int[] array)
    {
        var length = array.Length;
        var medianPosition = length / 2;

        if (length % 2 != 0)
        {
            return array[medianPosition];
        }

        return (array[medianPosition - 1] + array[medianPosition]) / 2d;
    }
}