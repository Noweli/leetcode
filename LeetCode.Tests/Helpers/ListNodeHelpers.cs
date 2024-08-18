namespace LeetCode.Tests.Helpers;

public static class ListNodeHelpers
{
    public static int[] ReadListNode(SharedModels.ListNode listNode)
    {
        List<int> output = [listNode.val];

        if (listNode.next is not null)
        {
            output.AddRange(ReadListNode(listNode.next));
        }

        return output.ToArray();
    }

    public static SharedModels.ListNode CreateListNodeWithValues(int[] values)
    {
        switch (values.Length)
        {
            case 0:
                return new SharedModels.ListNode();
            case 1:
                return new SharedModels.ListNode(values[0]);
        }

        var root = new SharedModels.ListNode
        {
            val = values[0]
        };

        var current = root;
        foreach (var value in values.Skip(1))
        {
            var newNode = new SharedModels.ListNode(value);
            current.next = newNode;
            current = newNode;
        }

        return root;
    }
}