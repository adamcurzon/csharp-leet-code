public class Solution
{
    public int Trap(int[] height)
    {
        int water = 0;
        int l = 0;
        int r = height.Length - 1;
        int lMax = height[l];
        int rMax = height[r];

        while (l < r)
        {
            if (lMax < rMax)
            {
                l++;
                lMax = Math.Max(height[l], lMax);
                water += lMax - height[l];
            }
            else
            {
                r--;
                rMax = Math.Max(height[r], rMax);
                water += rMax - height[r];
            }
        }
        return water;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]));
        Console.WriteLine(s.Trap([4, 2, 0, 3, 2, 5]));
        Console.WriteLine(s.Trap([2, 0, 2]));
        Console.WriteLine(s.Trap([4, 2, 3]));
    }
}
