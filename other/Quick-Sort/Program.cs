using System.Text.Json;

class Program
{
    public int[] QuickSort(int[] nums)
    {
        int[] r = [];

        int pivot = nums[nums.Length / 2];
        List<int> left = new();
        List<int> right = new();


        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > pivot)
            {
                right.Add(nums[i]);
            }
            else
            {
                left.Add(nums[i]);
            }
        }

        r = QuickSort(left.ToArray()).Concat(QuickSort(right.ToArray())).ToArray();

        Console.WriteLine("Output: " + JsonSerializer.Serialize(r) + "\n");

        return r;
    }
    static void Main()
    {
        Program p = new();
        p.QuickSort([11, 99, 88, 6, 77, 66, 55, 44, 33, 2, 11, 9, 92, 88, 91, 99]);
        p.QuickSort([1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 9, 8, 9, 9]);
    }
}
