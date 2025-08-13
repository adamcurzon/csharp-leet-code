public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Contains(target - nums[i]) && Array.IndexOf(nums, target - nums[i]) != i)
            {
                return [i, Array.IndexOf(nums, target - nums[i])];
            }
        }
        return [-1, -1];
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.TwoSum([2, 7, 11, 15], 9));
        Console.WriteLine(s.TwoSum([3, 2, 4], 6));
        Console.WriteLine(s.TwoSum([3, 3], 6));
    }
}
