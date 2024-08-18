using FluentAssertions;

namespace LeetCode.Tests;

public class LeetCode7Tests
{
    [TestCase(123, 321)]
    [TestCase(-123, -321)]
    [TestCase(120, 21)]
    public void Reverse_ReturnExpected(int input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode7.Reverse(input);
        
        // Assert
        result.Should().Be(expected);
    }
}