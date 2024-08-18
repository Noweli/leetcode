using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode9Tests
{
    [TestCase(121, true)]
    [TestCase(-121, false)]
    [TestCase(10, false)]
    public void IsPalindrome_ReturnExpected(int input, bool expected)
    {
        // Arrange
        // Act
        var result = LeetCode9.IsPalindrome(input);
        
        // Assert
        result.Should().Be(expected);
    }
}