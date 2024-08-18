using FluentAssertions;
using LeetCode.Tests.Helpers;

namespace LeetCode.Tests;

[TestFixture]
public class LeetCode21Tests
{
    [TestCase(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [TestCase(new int[] { }, new int[] { }, new [] { 0, 0 })]
    [TestCase(new int[] { }, new[] { 0 }, new[] { 0, 0 })]
    public void MergeTwoLists_ReturnExpected(int[] list1Values, int[] list2Values, int[] expected)
    {
        // Arrange
        var list1 = ListNodeHelpers.CreateListNodeWithValues(list1Values);
        var list2 = ListNodeHelpers.CreateListNodeWithValues(list2Values);
        
        // Act
        var solutionResult = LeetCode21.MergeTwoLists(list1, list2);
        var result = ListNodeHelpers.ReadListNode(solutionResult);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}