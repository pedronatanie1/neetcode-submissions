public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>();

        foreach(int x in nums)
        {
            if (!seen.Add(x))
            {
                return true;
            }
        }
        return false;
    }
}