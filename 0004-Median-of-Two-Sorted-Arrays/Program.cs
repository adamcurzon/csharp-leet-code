public class Program
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] combined = nums1.Concat(nums2).ToArray();
        Array.Sort(combined);

        // Has two numbers as median
        if (combined.Length % 2 == 0)
        {
            return (combined[combined.Length / 2] + combined[(combined.Length / 2) - 1]) / 2.0;
        }
        else
        { // Has single number median

            // [1,2,3]
            return combined[combined.Length / 2];
        }
    }
    static void Main()
    {
        int[] arr1 = [2, 2, 4, 4];
        int[] arr2 = [2, 2, 2, 4, 4];
        Console.WriteLine(FindMedianSortedArrays(arr1, arr2));
    }
}
