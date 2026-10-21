public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var seen = new Dictionary<int, int> {[0] = 1};

        int prefix = 0, count = 0;

        foreach(int x in nums)
        {
            prefix += x;
            count += seen.GetValueOrDefault(prefix - k);
            seen[prefix] = seen.GetValueOrDefault(prefix) + 1;
        }
        return count;
    }
}