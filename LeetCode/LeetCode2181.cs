namespace LeetCode;


public static class LeetCode2181
{
    public static SharedModels.ListNode MergeNodes(SharedModels.ListNode head)
    {
        var root = new SharedModels.ListNode();
        var currentNode = root;

        var currentSearchNode = head.next;
        while (true)
        {
            if (currentSearchNode?.next is null)
            {
                break;
            }
            
            if(currentSearchNode.val == 0)
            {
                var newNode = new SharedModels.ListNode();
                currentNode.next = newNode;
                currentNode = newNode;
                currentSearchNode = currentSearchNode.next;
                
                continue;
            }

            currentNode.val += currentSearchNode.val;
            currentSearchNode = currentSearchNode.next;
        }

        return root;
    }
    
    // Did not pass due to timeout
    public static SharedModels.ListNode MergeNodesApproach1(SharedModels.ListNode head)
    {
        var numbers = new List<int>();
        var merged = new List<int>();
        var values = ReadNodeList(head);
        
        foreach (var nodeValue in values.Skip(1))
        {
            if (nodeValue == 0)
            {
                merged.Add(numbers.Sum());
                numbers.Clear();
                continue;
            }

            numbers.Add(nodeValue);
        }

        return CreateListNodeWithValues(merged.ToArray());
    }

    private static int[] ReadNodeList(SharedModels.ListNode listNode)
    {
        List<int> output = [listNode.val];

        if (listNode.next is { } next)
        {
            output.AddRange(ReadNodeList(next));
        }

        return output.ToArray();
    }
    
    private static SharedModels.ListNode CreateListNodeWithValues(int[] values)
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