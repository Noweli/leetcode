using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode88Tests
{
    [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [TestCase(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [TestCase(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    public void Merge_ReturnExpected(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Arrange
        // Act
        LeetCode88.Merge(nums1, m, nums2, n);
        
        // Assert
        nums1.Should().BeEquivalentTo(expected);
    }
}