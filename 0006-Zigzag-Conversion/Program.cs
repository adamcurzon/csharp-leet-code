public class Solution
{
    /*
        Input: s = "(P)AYP(A)LIS(H)IRI(N)G", numRows = 3
        P   A   H   N
        A P L S I I G
        Y   I   R
        Output: "PAHN APLSIIGYIR"
                "PAHN YIRPAHNYIR"
        Example 2:

        Input: s = "(P)AYPAL(I)SHIRI(N)G", numRows = 4
        Output: "PINALSIGYAHRPI"
        Explanation:
        P     I    N
        A   L S  I G
        Y A   H R
        P     I
    */
    public List<List<string>> Convert(string s, int numRows)
    {
        string r = "";
        int p = 0;
        List<List<string>> board = new();

        for (int i = 0; i < numRows; i++)
        {
            List<string> row = new();
            for (int j = 0; j < s.Length; j++)
            {
                if (j % numRows - 1 == 0)
                {
                    row.Add("o");
                }
                else
                {
                    row.Add("x");
                }
            }
            board.Add(row);
        }

        return board;
    }
    static void Main()
    {
        Solution s = new();
        List<List<string>> converted = s.Convert("PAYPALISHIRING", 3);
        for (int i = 0; i < converted.Count; i++)
        {
            for (int j = 0; j < converted[0].Count; j++)
            {
                Console.Write(converted[i][j]);
            }
            Console.Write("\n");
        }
    }
}
