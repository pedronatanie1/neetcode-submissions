public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue, best = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            best = Math.Max(best, prices[i] - minPrice);
        }
        return best;
    }
}
