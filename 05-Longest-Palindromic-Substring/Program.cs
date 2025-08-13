public class Solution
{
    public string LongestPalindrome(string s)
    {
        string result = "";
        int longest = 0;

        int left = 0;
        int right = 0;

        for (int i = 0; i < s.Length; i++)
        {
            left = i;
            right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > longest)
                {
                    result = s.Substring(left, right - left + 1);
                    longest = right - left + 1;
                    Console.WriteLine($"{result} {longest}");
                }
                left -= 1;
                right += 1;
            }

            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                Console.WriteLine($"{right - left + 1} > {longest}");
                if (right - left + 1 > longest)
                {
                    result = s.Substring(left, right - left + 1);
                    longest = right - left + 1;
                    Console.WriteLine($"{result} {longest}");
                }
                left -= 1;
                right += 1;
            }
        }

        return result;
    }

    static void Main()
    {
        Solution s = new();
        string r2 = s.LongestPalindrome("bb");
        Console.WriteLine(r2);
    }
}
