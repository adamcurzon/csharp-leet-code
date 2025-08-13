public class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        // Stores the charater and the pointer location it was found at
        Dictionary<char, int> chars = new();
        int pointer = 0;
        int longest = 0;

        while (pointer < s.Length)
        {
            if (chars.ContainsKey(s[pointer]))
            {
                if (chars.Count > longest)
                {
                    longest = chars.Count;
                }
                // Go back to the next char after the first dupe
                pointer = chars[s[pointer]];
                pointer++;
                chars = new();
            }
            chars.Add(s[pointer], pointer);
            pointer++;
        }

        if (chars.Count > longest)
        {
            longest = chars.Count;
        }

        return longest;
    }

    static void Main(string[] args)
    {
        int r = LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine(r);
    }
}
