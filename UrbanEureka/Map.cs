public class Map
{
    public Point Origin { get; set;}
    private int[][] mapData;
    private Dictionary<CellType, char> cellVisuals = new Dictionary<CellType, char>{
        { CellType.WallCorner, '+'},
        { CellType.WallHorizontal, '-'},
        { CellType.WallVertical, '|'},
        { CellType.Floor, '.'},
        { CellType.Empty, ' '},
        { CellType.Grass, '#'},
    };

    private Dictionary<CellType, ConsoleColor> colorMap = new Dictionary<CellType, ConsoleColor> {
        { CellType.WallCorner, ConsoleColor.DarkBlue},
        { CellType.WallHorizontal, ConsoleColor.DarkBlue},
        { CellType.WallVertical, ConsoleColor.DarkBlue},
        { CellType.Floor, ConsoleColor.Magenta},
        { CellType.Empty, ConsoleColor.Black},
        { CellType.Grass, ConsoleColor.Green},
    };

    private CellType[] walkableCellTypes = new CellType[] { 
        CellType.Floor, 
        CellType.Grass,
    };

    public Map()
    {
        mapData = new int[][] {
            new []{1,2,2,2,1,9,9,1,2,2,2,1,},
            new []{3,0,0,0,1,2,2,1,0,0,0,3,},
            new []{3,0,0,0,0,0,0,0,1,0,0,3,},
            new []{1,2,2,1,2,2,1,4,3,0,4,3,},
            new []{9,9,9,3,0,0,0,4,3,0,4,3,},
            new []{9,9,9,3,0,0,0,1,1,0,0,3,},
            new []{9,9,9,3,0,0,0,0,0,0,0,3,},
            new []{9,9,9,1,2,2,2,2,2,2,2,1,},
        };

        Origin = new Point(0, 0);
    }

    public CellType GetCellAt(Point point)
    {
        return GetCellAt(point.X, point.Y);
    }

    private CellType GetCellAt(int x, int y)
    {
        return (CellType)mapData[y][x];
    }

    public char GetCellVisualAt(Point point)
    {
        return cellVisuals[GetCellAt(point)];
    }

    public void Display(Point origin)
    {
        Origin = origin;
        Console.CursorTop = origin.Y;
        for (int y = 0; y < mapData.Length; y++)
        {
            Console.CursorLeft = origin.X;
            for (int x = 0; x < mapData[y].Length; x++)
            {
                var cellValue = GetCellAt(x, y);
                var cellVisual = cellVisuals[cellValue];
                var cellColor = GetCellColorByValue(cellValue);
                Console.ForegroundColor = cellColor;
                Console.Write(cellVisual);
                Console.ResetColor();
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
                if (walkableCellTypes.Contains(GetCellAt(point)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    internal void DrawSomethingAt(char visual, Point position)
    {
        Console.SetCursorPosition(position.X + Origin.X, position.Y + Origin.Y);
        Console.Write(visual);
    }

    internal void DrawSomethingAt(string visual, Point position)
    {
        Console.SetCursorPosition(position.X + Origin.X, position.Y + Origin.Y);
        Console.Write(visual);
    }

    private ConsoleColor GetCellColorByValue(CellType value)
    {
        return colorMap.GetValueOrDefault(value, ConsoleColor.Gray);
    }

    internal void RedrawCellAt(Point position)
    {
        var cellValue = GetCellAt(position);
        var cellVisual = GetCellVisualAt(position);
        var cellColor = GetCellColorByValue(cellValue);

        Console.ForegroundColor = cellColor;
        DrawSomethingAt(cellVisual, position);
        Console.ResetColor();
    }
}