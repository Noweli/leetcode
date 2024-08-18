using FluentAssertions;

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
        var l1 = CreateListNodeWithValues(l1Values);
        var l2 = CreateListNodeWithValues(l2Values);

        // Act
        var solutionResult = LeetCode2.AddTwoNumbers(l1, l2);
        var result = ReadListNode(solutionResult);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    private static int[] ReadListNode(ListNode listNode)
    {
        List<int> output = [listNode.val];

        if (listNode.next is not null)
        {
            output.AddRange(ReadListNode(listNode.next));
        }

        return output.ToArray();
    }

    private static ListNode CreateListNodeWithValues(int[] values)
    {
        if (values.Length == 1)
        {
            return new ListNode(values[0]);
        }

        var root = new ListNode
        {
            val = values[0]
        };

        var current = root;
        foreach (var value in values.Skip(1))
        {
            var newNode = new ListNode(value);
            current.next = newNode;
            current = newNode;
        }

        return root;
    }
}