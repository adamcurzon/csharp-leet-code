
using System.Collections;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // number in array, frequency
        Dictionary<int, int> counts = new();
        Dictionary<int, List<int>> sortedCounts = new();
        int[] r = new int[k];
        int rPointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            counts.TryAdd(nums[i], 0);
            counts[nums[i]] += 1;
            sortedCounts.TryAdd(i + 1, []);
        }

        foreach (KeyValuePair<int, int> c in counts)
        {
            sortedCounts[c.Value].Add(c.Key);
        }

        for (int i = sortedCounts.Keys.Max(); i >= 0; i--)
        {
            foreach (int num in sortedCounts[i])
            {
                r[rPointer] = num;
                rPointer++;
                if (rPointer >= k)
                {
                    return r;
                }
            }
        }

        return r;
    }

    static void Main()
    {
        Solution s = new();
        // Console.WriteLine(s.TopKFrequent([1, 1, 1, 2, 2, 3], 2));
        // Console.WriteLine(s.TopKFrequent([1], 1));
        // Console.WriteLine(s.TopKFrequent([-1, -1], 1));
        Console.WriteLine(s.TopKFrequent([5, 3, 1, 1, 1, 3, 73, 1], 2));
    }
}
