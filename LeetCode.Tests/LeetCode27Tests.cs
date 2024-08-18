using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode27Tests
{
    [TestCase(new[] { 3, 2, 2, 3 }, 3, 2)]
    [TestCase(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void RemoveElement_ReturnExpected(int[] nums, int valueToRemove, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode27.RemoveElement(nums, valueToRemove);

        // Assert
        result.Should().Be(expected);
    }
}