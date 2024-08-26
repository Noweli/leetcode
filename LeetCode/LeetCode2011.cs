namespace LeetCode;

public static class LeetCode2011
{
    public static int FinalValueAfterOperations(string[] operations)
    {
        var x = 0;
        foreach (var operation in operations)
        {
            if (operation.Contains('-'))
            {
                x--;
                continue;
            }

            x++;
        }

        return x;
    }
}