using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2469Tests
{
    [TestCase(36.5d, new[] { 309.65000d, 97.70000d })]
    [TestCase(122.11d, new[] { 395.26000d, 251.79800d })]
    public void ConvertTemperature_ReturnsExpected(double celsius, double[] expected)
    {
        // Arrange
        // Act
        var result = LeetCode2469.ConvertTemperature(celsius);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}