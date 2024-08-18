namespace LeetCode;

public static class LeetCode69
{
    public static int MySqrt(int x)
    {
        var increment = false;
        long b = 2;
        long previous = 0;
        while (true)
        {
            if (b * b > x)
            {
                if (!increment)
                {
                    b = previous;
                    increment = true;
                    continue;
                }

                return (int)--b;
            }

            if (b * b == x)
            {
                if (!increment)
                {
                    b = previous;
                    increment = true;
                    continue;
                }

                return (int)b;
            }

            if (increment)
            {
                b++;
            }
            else
            {
                previous = b;
                b *= b;
            }
        }
    }
}