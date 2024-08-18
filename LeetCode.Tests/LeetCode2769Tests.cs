using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2769Tests
{
    [TestCase(4, 1, 6)]
    [TestCase(3, 2, 7)]
    public void TheMaximumAchievableX_ReturnExpected(int num, int t, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode2769.TheMaximumAchievableX(num, t);
        
        // Assert
        result.Should().Be(expected);
    }
}