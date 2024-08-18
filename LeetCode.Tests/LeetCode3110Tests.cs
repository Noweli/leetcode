using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode3110Tests
{
    [TestCase("hello", 13)]
    [TestCase("zaz", 50)]
    public void Test(string input, int expected)
    {
        //Arrange
        //Act
        var result = LeetCode3110.ScoreOfString(input);
        //Assert
        result.Should().Be(expected);
    }
}