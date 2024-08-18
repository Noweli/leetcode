using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode69Tests
{
    [TestCase(4, 2)]
    [TestCase(8, 2)]
    [TestCase(9, 3)]
    public void MySqrt_ReturnExpected(int input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode69.MySqrt(input);
        
        // Assert
        result.Should().Be(expected);
    }
}