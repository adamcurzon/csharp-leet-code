public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int lBuy = 0;
        int rSell = 1;
        int profit = 0;

        while (rSell < prices.Length)
        {
            if (prices[lBuy] < prices[rSell])
            {
                profit = Math.Max(profit, prices[rSell] - prices[lBuy]);
            }
            else
            {
                lBuy = rSell;
            }
            rSell++;
        }

        return profit;
    }

    static void Main()
    {
        Solution s = new();
        Console.WriteLine(s.MaxProfit([7, 1, 5, 3, 6, 4]));
        Console.WriteLine(s.MaxProfit([7, 6, 4, 3, 1]));
    }
}
