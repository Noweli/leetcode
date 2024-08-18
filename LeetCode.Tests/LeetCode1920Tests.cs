using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode1920Tests
{
    [TestCase(new[] { 0, 2, 1, 5, 3, 4 }, new[] { 0, 1, 2, 4, 5, 3 })]
    [TestCase(new[] { 5, 0, 1, 2, 3, 4 }, new[] { 4, 5, 0, 1, 2, 3 })]
    public void BuildArray_ReturnExpected(int[] input, int[] expected)
    {
        // Arrange
        // Act
        var result = LeetCode1920.BuildArray(input);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}