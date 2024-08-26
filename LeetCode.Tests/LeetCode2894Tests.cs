using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2894Tests
{
    [TestCase(10, 3, 19)]
    [TestCase(5, 6, 15)]
    [TestCase(5, 1, -15)]
    public void DifferenceOfSums(int n, int m, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode2894.DifferenceOfSums(n, m);

        // Assert
        result.Should().Be(expected);
    }
}