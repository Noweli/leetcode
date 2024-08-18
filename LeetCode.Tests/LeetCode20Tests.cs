using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode20Tests
{
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    public void IsValid_ReturnExpected(string input, bool expected)
    {
        // Arrange
        // Act
        var result = LeetCode20.IsValid(input);

        // Assert
        result.Should().Be(expected);
    }
}