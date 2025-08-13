public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> sMap = new();
        Dictionary<char, int> tMap = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (sMap.ContainsKey(s[i]))
            {
                sMap[s[i]]++;
            }
            else
            {
                sMap.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!sMap.ContainsKey(t[i]))
            {
                return false;
            }
            if (tMap.ContainsKey(t[i]))
            {
                tMap[t[i]] += 1;
            }
            else
            {
                tMap.Add(t[i], 1);
            }
            if (tMap[t[i]] > sMap[t[i]])
            {
                return false;
            }
        }

        for (int i = 0; i < sMap.Count; i++)
        {
            if (!tMap.ContainsKey(s[i]) || tMap[s[i]] != sMap[s[i]])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.IsAnagram("anagram", "nagaram"));
        Console.WriteLine(s.IsAnagram("rat", "car"));
    }
}
