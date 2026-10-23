public class Solution {
    public int NumIslands(char[][] grid) {
        int numberOfIslands = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[0].Length; column++)
            {
                if (grid[row][column] == '1')
                {
                    numberOfIslands++;
                    Sink(grid, row, column);
                }
            }
        }
        return numberOfIslands;
    }

    private void Sink(char[][] grid, int row, int column)
    {
        if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length)
            return;
        if (grid[row][column] != '1')
            return;
            
        grid[row][column] = '0';
        Sink(grid, row + 1, column);
        Sink(grid, row - 1, column);
        Sink(grid, row, column + 1);
        Sink(grid, row, column - 1);
    }
}
