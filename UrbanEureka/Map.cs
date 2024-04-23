
public class Map
{
    private char[][] mapData;

    public Map()
    {
        mapData = new char[][] {
            new []{'#','#','#','#','#','#','#','#','#','#','#','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','.','.','.','.','.','.','.','.','.','.','#',},
            new []{'#','#','#','#','#','#','#','#','#','#','#','#',},
        };
    }

    public char GetCellAt(Point point)
    {
        return mapData[point.Y][point.X];
    }

    public void Display()
    {
        for (int y = 0; y < mapData.Length; y++)
        {
            for (int x = 0; x < mapData[y].Length; x++)
            {
                Console.Write(mapData[y][x]);
            }
            Console.WriteLine();
        }
    }

    internal bool IsPointCorrect(Point point)
    {
        if (point.Y >= 0 && point.Y < mapData.Length)
        {
            if (point.X >= 0 && point.X < mapData[point.Y].Length)
            {
                if (GetCellAt(point) != '#')
                {
                    return true;
                }
            }
        }

        return false;
    }
}