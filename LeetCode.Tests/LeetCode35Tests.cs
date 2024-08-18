using FluentAssertions;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode35Tests
{
    [TestCase(new[] {1,3,5,6}, 5, 2)]
    [TestCase(new[] {1,3,5,6}, 2, 1)]
    [TestCase(new[] {1,3,5,6}, 7, 4)]
    public void SearchInsert_ReturnExpected(int[] nums, int target, int expected)
    {
        // Arrange
        // Act
        var result = LeetCode35.SearchInsert(nums, target);
        
        // Assert
        result.Should().Be(expected);
    }
}