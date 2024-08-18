using FluentAssertions;
using LeetCode.Tests.Helpers;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode2Tests
{
    [TestCase(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [TestCase(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [TestCase(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    public void AddTwoNumbers_ReturnExpected(int[] l1Values, int[] l2Values, int[] expected)
    {
        // Arrange
        var l1 = ListNodeHelpers.CreateListNodeWithValues(l1Values);
        var l2 = ListNodeHelpers.CreateListNodeWithValues(l2Values);

        // Act
        var solutionResult = LeetCode2.AddTwoNumbers(l1, l2);
        var result = ListNodeHelpers.ReadListNode(solutionResult);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    
}