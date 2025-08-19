public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int longest = 0;
        int l = 0;
        int r = 1;
        int firstSkipPos = 0;
        int skips = k;

        while (l < s.Length)
        {
            Console.WriteLine($"{s[l]} {s[r]} {longest}");
            if (s[l] != s[r])
            {
                if (firstSkipPos == 0)
                {
                    firstSkipPos = r;
                }
                skips--;
            }
            else
            {
                r++;
            }
            if (skips == 0)
            {
                longest = Math.Max(r - l, longest);
                skips = k;
                l = firstSkipPos;
                r = firstSkipPos + 1;
                firstSkipPos = 0;
            }
        }

        return longest;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.CharacterReplacement("ABAB", 2));
        Console.WriteLine(s.CharacterReplacement("AABABBA", 1));
    }
}
