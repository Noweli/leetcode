using FluentAssertions;
using LeetCode.Tests.Helpers;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode83Tests
{
    [TestCase(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [TestCase(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
    public void DeleteDuplicates_ReturnExpected(int[] nodeValues, int[] expected)
    {
        // Arrange
        var list = ListNodeHelpers.CreateListNodeWithValues(nodeValues);
        
        // Act
        var solutionResult = LeetCode83.DeleteDuplicates(list);
        var result = ListNodeHelpers.ReadListNode(solutionResult);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}