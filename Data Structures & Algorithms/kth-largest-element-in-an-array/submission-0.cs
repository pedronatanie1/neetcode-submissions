public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var heap = new PriorityQueue<int, int>();

        foreach (int x in nums)
        {
            heap.Enqueue(x, x);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        return heap.Peek();
    }
}
