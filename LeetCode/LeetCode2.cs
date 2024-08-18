using System.Numerics;
using System.Text;

namespace LeetCode;

public static class LeetCode2
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var node1 = ReverseString(GetListNodeAsString(l1));
        var node2 = ReverseString(GetListNodeAsString(l2));
        var sum = AddTwoStringsBigInt(node1, node2).ToString();

        return ConvertStringToListNode(sum);
    }

    private static string GetListNodeAsString(ListNode list)
    {
        var builder = new StringBuilder();
        builder.Append(list.val);

        if (list.next is not null)
        {
            builder.Append(GetListNodeAsString(list.next));
        }

        return builder.ToString();
    }

    private static ListNode ConvertStringToListNode(string input)
    {
        var inputAsArray = ReverseString(input).ToArray().Select(v => v - '0').ToArray();

        var first = new ListNode(inputAsArray[0]);
        var previous = first;
        for (var i = 1; i < inputAsArray.Length; i++)
        {
            var current = new ListNode(inputAsArray[i]);
            previous.next = current;
            previous = current;
        }

        return first;
    }

    private static string ReverseString(string input) => string.Join("", input.Reverse());

    private static BigInteger AddTwoStringsBigInt(string str1, string str2) =>
        BigInteger.Add(BigInteger.Parse(str1), BigInteger.Parse(str2));
}

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}