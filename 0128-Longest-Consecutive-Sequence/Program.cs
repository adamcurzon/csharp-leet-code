public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> numsSet = new HashSet<int>(nums);
        HashSet<int> visited = new();
        int longest = 0;
        bool escape = false;
        int addPointer = 0;
        int subPointer = 0;

        foreach (int num in numsSet)
        {
            if (visited.Contains(num))
            {
                continue;
            }

            visited.Add(num);

            subPointer = 0;
            addPointer = 0;
            escape = false;

            // Addition
            while (!escape)
            {
                if (nums.Contains(num + addPointer + 1))
                {
                    visited.Add(num + addPointer + 1);
                    addPointer++;
                }
                else
                {
                    escape = true;
                }
            }

            escape = false;

            // Subtraction
            while (!escape)
            {
                if (nums.Contains(num - subPointer - 1))
                {
                    visited.Add(num - subPointer - 1);
                    subPointer++;
                }
                else
                {
                    escape = true;
                }
            }
            if (subPointer + addPointer + 1 > longest)
            {
                longest = subPointer + addPointer + 1;
            }
        }

        return longest;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.LongestConsecutive([100, 4, 200, 1, 3, 2]));
        Console.WriteLine(s.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));
        Console.WriteLine(s.LongestConsecutive([1, 0, 1, 2]));
    }
}
