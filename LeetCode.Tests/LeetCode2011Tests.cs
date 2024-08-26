using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2011Tests
{
    [TestCase(new[] {"--X","X++","X++"}, 1)]
    [TestCase(new[] {"++X","++X","X++"}, 3)]
    [TestCase(new[] {"X++","++X","--X","X--"}, 0)]
    public void FinalValueAfterOperations_ReturnsExpected(string[] operations, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode2011.FinalValueAfterOperations(operations);
        
        // Assert
        result.Should().Be(expected);
    }
}