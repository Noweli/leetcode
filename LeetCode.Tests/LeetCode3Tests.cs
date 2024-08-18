using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode3Tests
{
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    public void LengthOfLongestSubstring_ReturnExpected(string input, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode3.LengthOfLongestSubstring(input);
        
        // Assert
        result.Should().Be(expected);
    }
}