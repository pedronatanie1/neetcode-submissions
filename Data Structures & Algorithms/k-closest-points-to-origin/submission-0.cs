public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var heap = new PriorityQueue<int[], int>();

        foreach (var p in points)
        {
            int distance = p[0] * p[0] + p[1] * p[1];
            heap.Enqueue(p, -distance);
            if (heap.Count > k)
                heap.Dequeue();
        }

        var result = new int[k][];
        for (int i = 0; i < k; i++)
        {
            result[i] = heap.Dequeue();
        }
        return result;
    }
}
