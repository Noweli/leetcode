using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode13Tests
{
    [TestCase("III", 3)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXCIV", 1994)]
    public void RomanToInt_ReturnExpected(string input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode13.RomanToInt(input);
        
        // Assert
        result.Should().Be(expected);
    }
}