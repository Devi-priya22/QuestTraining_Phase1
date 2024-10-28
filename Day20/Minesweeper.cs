using System;

class Minesweeper
{
    enum CellType
    {
        Point1,
        Point2,
        Mine
    }

    static int size = 5;
    static int minesCount = 5;
    static CellType[,] grid = new CellType[size, size];
    static char[,] displayGrid = new char[size, size];
    static int points = 0;

    public static void Main()
    {
        InitializeGame();
        PlayGame();
    }

    static void InitializeGame()
    {
        var random = new Random();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                grid[i, j] = CellType.Point1;  // Default value
                displayGrid[i, j] = '*';
            }
        }

        // Place mines randomly
        int placedMines = 0;
        while (placedMines < minesCount)
        {
            int row = random.Next(size);
            int col = random.Next(size);
            if (grid[row, col] != CellType.Mine)
            {
                grid[row, col] = CellType.Mine;
                placedMines++;
            }
        }

        // Assign Point1 and Point2 to other cells
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (grid[i, j] != CellType.Mine)
                {
                    grid[i, j] = (CellType)random.Next(0, 2);  // Point1 or Point2
                }
            }
        }
    }

    static void PlayGame()
    {
        var random = new Random();
        while (true)
        {
            PrintGrid();
            Console.Write("Enter row index (0-4): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column index (0-4): ");
            int col = int.Parse(Console.ReadLine());

            if (grid[row, col] == CellType.Mine)
            {
                Console.WriteLine("You hit a mine. Game Over.");
                Console.WriteLine($"Total Points: {points}");
                break;
            }
            else
            {
                int randomNumber = random.Next(1, 10); // Random number between 1 and 9
                displayGrid[row, col] = randomNumber.ToString()[0];

                if (grid[row, col] == CellType.Point1)
                {
                    points += 1;
                }
                else if (grid[row, col] == CellType.Point2)
                {
                    points += 2;
                }

                Console.WriteLine("Safe! Keep going.");
            }
        }
    }

    static void PrintGrid()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(displayGrid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
