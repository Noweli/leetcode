using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode14Tests
{
    [TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
    [TestCase(new string[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_ReturnExpected(string[] input, string expected)
    {
        // Arrange
        // Act
        var result = LeetCode14.LongestCommonPrefix(input);
        
        // Assert
        result.Should().Be(expected);
    }
}