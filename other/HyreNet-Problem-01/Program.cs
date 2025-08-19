class Program
{
    public void DistinctSubstrings(string s)
    {
        // KnownRepeatingLengths
        // M => 3
        // N => 3
        Dictionary<char, int> KnownRepeatingLengths = new();
        // KnownDuplicatedRepeatingLengths
        // M => 3
        // N => 3
        Dictionary<char, int> KnownDuplicatedRepeatingLengths = new();

        int l = 0;
        int r = 1;

        while (r <= s.Length - 1)
        {
            if (s[l] == s[r])
            {
                KnownRepeatingLengths.TryAdd(s[l], 0);
                KnownDuplicatedRepeatingLengths.TryAdd(s[l], 0);
                if (KnownRepeatingLengths[s[l]] >= r - l + 1)
                {
                    KnownDuplicatedRepeatingLengths[s[l]] = r - l + 1;
                }
                if (r - l + 1 > KnownRepeatingLengths[s[l]])
                {
                    KnownRepeatingLengths[s[l]] = r - l + 1;
                }
            }
            else
            {
                l = r;
            }
            r++;
        }
        foreach (var keyPair in KnownDuplicatedRepeatingLengths)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat(keyPair.Key, keyPair.Value)));
        }

    }
    static void Main()
    {
        Program p = new();
        p.DistinctSubstrings("mmmnnnmmmnnn");
    }
}
