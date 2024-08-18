using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode66Tests
{
    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [TestCase(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [TestCase(new[] { 9 }, new[] { 1, 0 })]
    public void PlusOne_ReturnExpected(int[] input, int[] expected)
    {
        // Arrange
        // Act
        var result = LeetCode66.PlusOne(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}