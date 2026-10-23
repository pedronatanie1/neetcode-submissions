public class Solution {
    public int OrangesRotting(int[][] grid) {
        var rottenQueue = new Queue<int[]>();
        int freshCount = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[0].Length; column++)
            {
                if (grid[row][column] == 2)
                    rottenQueue.Enqueue(new int[] { row, column });
                else if (grid[row][column] == 1)
                    freshCount++;         
            }
        }

        int minutes = 0;

        while (rottenQueue.Count > 0 && freshCount > 0)
        {
            int rottenThisMinute = rottenQueue.Count;

            for (int i = 0; i < rottenThisMinute; i++)
            {
                int[] orange = rottenQueue.Dequeue();
                int row = orange[0];
                int column = orange[1];

                if (RotIfFresh(grid, row + 1, column, rottenQueue)) 
                    freshCount--;  
                if (RotIfFresh(grid, row - 1, column, rottenQueue)) 
                    freshCount--;  
                if (RotIfFresh(grid, row, column + 1, rottenQueue)) 
                    freshCount--;  
                if (RotIfFresh(grid, row, column - 1, rottenQueue)) 
                    freshCount--;
            }
            minutes++;
        }
        
        if (freshCount == 0)
            return minutes;
        return -1;
    }

    private bool RotIfFresh(int[][] grid, int row, int column, Queue<int[]> rottenQueue)
    {
        if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length)
            return false;

        if (grid[row][column] != 1)
            return false;  

        grid[row][column] = 2;                             
        rottenQueue.Enqueue(new int[] { row, column });     
        return true;
    }
}
