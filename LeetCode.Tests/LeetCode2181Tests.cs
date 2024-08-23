using FluentAssertions;
using LeetCode.Tests.Helpers;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2181Tests
{
    [TestCase(new[] { 0, 3, 1, 0, 4, 5, 2, 0 }, new[] { 4, 11 })]
    [TestCase(new[] { 0, 1, 0, 3, 0, 2, 2, 0 }, new[] { 1, 3, 4 })]
    public void MergeNodes_ReturnExpected(int[] values, int[] expected)
    {
        // Arrange
        var list = ListNodeHelpers.CreateListNodeWithValues(values);
        
        // Act
        var solutionResult = LeetCode2181.MergeNodes(list);
        var result = ListNodeHelpers.ReadListNode(solutionResult);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}