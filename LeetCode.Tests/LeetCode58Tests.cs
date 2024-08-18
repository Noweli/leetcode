using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode58Tests
{
    [TestCase("Hello World", 5)]
    [TestCase("   fly me   to   the moon  ", 4)]
    [TestCase("luffy is still joyboy", 6)]
    public void LengthOfLastWord_ReturnExpected(string input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode58.LengthOfLastWord(input);
        
        // Assert
        result.Should().Be(expected);
    }
}