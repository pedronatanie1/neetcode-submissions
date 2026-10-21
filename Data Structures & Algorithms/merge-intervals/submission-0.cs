public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        var merged = new List<int[]>();

        foreach(var next in intervals)
        {
            if (merged.Count > 0 && next[0] <= merged[merged.Count - 1][1])
            {
                var last = merged[merged.Count - 1];
                last[1] = Math.Max(next[1], last[1]);
            }
            else
            {
                merged.Add(next);
            }
        }
        return merged.ToArray();
    }
}
