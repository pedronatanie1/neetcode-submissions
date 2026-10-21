public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var answer = new int[temperatures.Length];
        var waiting = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (waiting.Count > 0 && temperatures[i] > temperatures[waiting.Peek()])
            {
                int j = waiting.Pop();
                answer[j] = i - j;
            }
            waiting.Push(i);
        }
        return answer;
    }
}
