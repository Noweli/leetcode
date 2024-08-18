namespace LeetCode;

public static class LeetCode83
{
    public static SharedModels.ListNode DeleteDuplicates(SharedModels.ListNode head)
    {
        var running = true;
        var currentSearch = head;
        SharedModels.ListNode? lookingForNext = null;
        
        while (running)
        {
            if (currentSearch?.next is null)
            {
                if (lookingForNext != null)
                {
                    lookingForNext.next = null;
                }
                
                running = false;
                continue;
            }
            
            if (currentSearch.val == currentSearch.next!.val)
            {
                if (lookingForNext is null)
                {
                    lookingForNext = currentSearch;
                }
                
                currentSearch = currentSearch.next;
                continue;
            }

            if (lookingForNext is not null)
            {
                lookingForNext.next = currentSearch.next;
                lookingForNext = null;
            }
            
            currentSearch = currentSearch.next;
        }

        return head;
    }
}