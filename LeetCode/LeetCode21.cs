namespace LeetCode;

public static class LeetCode21
{
    public static SharedModels.ListNode MergeTwoLists(SharedModels.ListNode list1, SharedModels.ListNode list2) {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }

        list2.next = MergeTwoLists(list1, list2.next);
        
        return list2;
    }
}