using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode4Tests
{
    [TestCase(new[] {1,3}, new[] {2}, 2d)]
    [TestCase(new[] {1,2}, new[] {3,4}, 2.5d)]
    public void FindMedianSortedArrays_ReturnExpected(int[] nums1, int[] nums2, double expected)
    {
        // Arrange
        // Act
        var result = LeetCode4.FindMedianSortedArrays(nums1, nums2);
        
        // Assert
        result.Should().Be(expected);
    }
}