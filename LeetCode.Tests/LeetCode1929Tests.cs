using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode1929Tests
{
    [TestCase(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [TestCase(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
    public void GetConcatenation_ReturnExpected(int[] input, int[] expected)
    {
        // Arrange
        // Act
        var result = LeetCode1929.GetConcatenation(input);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}