using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode1108Tests
{
    [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
    [TestCase("255.100.50.0", "255[.]100[.]50[.]0")]
    // ReSharper disable once IdentifierTypo
    public void DefangIPaddr_ReturnExpected(string address, string expected)
    {
        // Arrange
        // Act
        var result = LeetCode1108.DefangIPaddr(address);
        
        // Assert
        result.Should().Be(expected);
    }
}