public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> r = [];
        Dictionary<string, int> keyMap = new();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] strArr = strs[i].ToArray();
            Array.Sort(strArr);
            string? key = String.Join("", strArr);
            if (keyMap.ContainsKey(key))
            {
                r[keyMap[key]].Add(strs[i]);
            }
            else
            {
                r.Add([]);
                keyMap.Add(key, r.Count - 1);
                r[r.Count - 1].Add(strs[i]);
            }
        }

        return r;
    }

    static void Main()
    {
        Solution s = new();
        s.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
    }
}
