public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                char charToCheck = board[i][j];
                // X axis and Y axis
                for (int a = 0; a < board[i].Length; a++)
                {
                    // X axis
                    // Console.WriteLine($"x axis {board[i][a]} == {charToCheck} && {i} != {a}");
                    if (board[i][a] == charToCheck && i != a && j != a)
                    {
                        return false;
                    }
                    // Y axis
                    // Console.WriteLine($"y axis {board[a][j]} == {charToCheck} && {j} != {a}");
                    if (board[a][j] == charToCheck && j != a && i != a)
                    {
                        return false;
                    }
                }
                // little square
                int iq = i / 3;
                int jq = j / 3;
                // Console.WriteLine($"Which Quarter: {i} {j} {(i + 1) / 3} {(j + 1) / 3}");
                for (int i1 = iq * 3; i1 < (iq * 3) + 3; i1++)
                {
                    for (int j1 = jq * 3; j1 < (jq * 3) + 3; j1++)
                    {
                        // Console.WriteLine($"{i1} {j1} {board[i1][j1]} {charToCheck}");
                        if (board[i1][j1] == '.')
                        {
                            continue;
                        }
                        // Console.WriteLine($"{charToCheck} == {board[i1][j1]} && {i1} != {i} && {j1} != {j}");
                        if (charToCheck == board[i1][j1] && i1 != i && j1 != j)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.IsValidSudoku(
            [
                ['.','.','.','.','5','.','.','1','.'],
                ['.','4','.','3','.','.','.','.','.'],
                ['.','.','.','.','.','3','.','.','1'],
                ['8','.','.','.','.','.','.','2','.'],
                ['.','.','2','.','7','.','.','.','.'],
                ['.','1','5','.','.','.','.','.','.'],
                ['.','.','.','.','.','2','.','.','.'],
                ['.','2','.','9','.','.','.','.','.'],
                ['.','.','4','.','.','.','.','.','.']
            ]
        ));
        Console.WriteLine(s.IsValidSudoku(
            [
                ['5','3','.','.','7','.','.','.','.']
                   ,['6','.','.','1','9','5','.','.','.']
                   ,['.','9','8','.','.','.','.','6','.']
                   ,['8','.','.','.','6','.','.','.','3']
                   ,['4','.','.','8','.','3','.','.','1']
                   ,['7','.','.','.','2','.','.','.','6']
                   ,['.','6','.','.','.','.','2','8','.']
                   ,['.','.','.','4','1','9','.','.','5']
                   ,['.','.','.','.','8','.','.','7','9']
            ]
        ));
        Console.WriteLine(s.IsValidSudoku(
        [
             ['8','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']
        ]
    ));
    }
}
