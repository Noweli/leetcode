using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode28Tests
{
    [TestCase("sadbutsad", "sad", 0)]
    [TestCase("leetcode", "leeto", -1)]
    public void StrStr_ReturnExpected(string haystack, string needle, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode28.StrStr(haystack, needle);
        
        // Assert
        result.Should().Be(expected);
    }
}