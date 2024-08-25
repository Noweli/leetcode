using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode3190Tests
{
    [TestCase(new[] { 1, 2, 3, 4 }, 3)]
    [TestCase(new[] { 3, 6, 9 }, 0)]
    public void MinimumOperations_ReturnExpected(int[] nums, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode3190.MinimumOperationsCount(nums);
        
        // Assert
        result.Should().Be(expected);
    }
}