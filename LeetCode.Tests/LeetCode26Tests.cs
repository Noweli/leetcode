using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode26Tests
{
    [TestCase(new[] { 1, 1, 2 }, 2)]
    [TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicates_ReturnExpected(int[] input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode26.RemoveDuplicates(input);

        // Assert
        result.Should().Be(expected);
    }
    
    [TestCase(new[] { 1, 1, 2 }, 2)]
    [TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicatesLinq_ReturnExpected(int[] input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode26.RemoveDuplicatesLinq(input);

        // Assert
        result.Should().Be(expected);
    }
}