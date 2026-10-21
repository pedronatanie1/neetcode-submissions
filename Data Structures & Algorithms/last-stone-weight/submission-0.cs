public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int, int>();

        foreach(var s in stones)
            heap.Enqueue(s, -s);

        while (heap.Count > 1)
        {
            int a = heap.Dequeue();
            int b = heap.Dequeue();
            if (a != b)
                heap.Enqueue(a - b, -(a - b));
        }
        return heap.Count == 0 ? 0 : heap.Peek();
    }
}
