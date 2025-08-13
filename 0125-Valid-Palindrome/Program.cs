public class Solution
{
    public bool IsPalindrome(string s)
    {
        List<char> letters = new();
        int left = 0;
        int right = 0;
        foreach (char letter in s)
            if (Char.IsLetterOrDigit(letter))
                letters.Add(Char.ToLower(letter));

        if (letters.Count % 2 == 0)
        {
            left = letters.Count / 2 - 1;
            right = letters.Count / 2;
            while (left >= 0 && right < letters.Count)
            {
                if (letters[left] != letters[right]) return false;
                left--;
                right++;
            }
        }
        else
        {
            left = letters.Count / 2 + 1;
            right = letters.Count / 2 - 1;
            while (left >= 0 && right < letters.Count)
            {
                if (letters[left] != letters[right]) return false;
                left--;
                right++;
            }
        }
        return true;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(s.IsPalindrome("racecar"));
        Console.WriteLine(s.IsPalindrome("raceecar"));
        Console.WriteLine(s.IsPalindrome("0P"));
    }
}
