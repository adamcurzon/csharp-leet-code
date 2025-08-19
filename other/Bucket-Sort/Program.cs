using System.Text.Json;

class Program
{
    public List<int> SortSingleDigits(int[] nums)
    {
        List<int> r = new();
        Dictionary<int, List<int>> buckets = new();

        Console.WriteLine("Input: " + JsonSerializer.Serialize(nums));

        for (int i = 0; i < nums.Length; i++)
        {
            buckets.TryAdd(nums[i], []);
            buckets[nums[i]].Add(nums[i]);
        }

        for (int i = 0; i <= 9; i++)
            if (buckets.ContainsKey(i))
                foreach (int value in buckets[i])
                    r.Add(value);

        Console.WriteLine("Output: " + JsonSerializer.Serialize(r) + "\n");

        return r;
    }

    public List<int> SortDoubleDigits(int[] nums)
    {
        List<int> r = new();
        Dictionary<int, List<int>> lastDigitBucket = new();
        Dictionary<int, List<int>> firstDigitBucket = new();

        Console.WriteLine("Input: " + JsonSerializer.Serialize(nums));

        // First sort the numbers into buckets based on the last digit
        for (int i = 0; i < nums.Length; i++)
        {
            int lastDigit = nums[i] % 10;
            lastDigitBucket.TryAdd(lastDigit, []);
            lastDigitBucket[lastDigit].Add(nums[i]);
        }

        // Now sort the numbers into buckets based on the first digit
        for (int i = 0; i <= 9; i++)
        {
            if (!lastDigitBucket.ContainsKey(i))
                continue;

            foreach (int num in lastDigitBucket[i])
            {
                int firstDigit = num / 10;
                firstDigitBucket.TryAdd(firstDigit, []);
                firstDigitBucket[firstDigit].Add(num);
            }
        }

        // Empty the bucket into an array
        for (int i = 0; i <= 9; i++)
            if (firstDigitBucket.ContainsKey(i))
                foreach (int value in firstDigitBucket[i])
                    r.Add(value);

        Console.WriteLine("Output: " + JsonSerializer.Serialize(r) + "\n");

        Console.WriteLine("Output: " + JsonSerializer.Serialize(r) + "\n");

        return r;
    }

    static void Main()
    {
        Program p = new Program();
        p.SortDoubleDigits([11, 99, 88, 6, 77, 66, 55, 44, 33, 2, 11, 9, 92, 88, 91, 99]);
        p.SortSingleDigits([1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 9, 8, 9, 9]);
    }
}
