namespace LeetCode;

public static class LeetCode66
{
    public static int[] PlusOne(int[] digits) 
    {
        if(digits is [9]){
            return [1,0];
        }


        for(var i = digits.Length-1 ; i >= 0 ; i--){
            if(digits[i] == 9){
                digits[i] = 0;
                if(i == 0){
                    return [1, ..digits];
                }
                continue;
            }

            digits[i] = ++digits[i];

            return digits;
        }

        return [];
    }
}