using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode1512Tests
{
    [TestCase(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
    [TestCase(new[] { 1,1,1,1 }, 6)]
    [TestCase(new[] { 1,2,3 }, 0)]
    public void NumIdenticalPairs_ReturnExpected(int[] nums, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode1512.NumIdenticalPairs(nums);
        
        // Assert
        result.Should().Be(expected);
    }
}