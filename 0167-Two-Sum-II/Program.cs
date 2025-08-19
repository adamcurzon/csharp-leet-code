using System.Collections;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;
        while (l < r)
        {
            int total = numbers[l] + numbers[r];
            if (total > target)
            {
                r--;
            }
            else if (total < target)
            {
                l++;
            }
            else
            {
                return [l + 1, r + 1];
            }
        }

        return [-1, -1];
    }
    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.TwoSum([2, 7, 11, 15], 9));
        Console.WriteLine(s.TwoSum([2, 3, 4], 6));
        Console.WriteLine(s.TwoSum([-1, 0], -1));
    }
}
