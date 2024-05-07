
public class Map
{
    public Point Origin { get; set;}
    private int[][] mapData;
    private Dictionary<int, char> cellVisuals = new Dictionary<int, char>{
        { 1, '#'},
        { 0, '.'},
        { 9, ' '},
    };

    public Map()
    {
        mapData = new int[][] {
            new []{1,1,1,1,1,1,1,1,1,1,1,1,},
            new []{1,0,0,0,1,1,1,1,0,0,0,1,},
            new []{1,0,0,0,0,0,0,0,1,0,0,1,},
            new []{1,1,1,1,1,1,1,0,1,0,0,1,},
            new []{9,9,9,1,0,0,0,0,1,0,0,1,},
            new []{9,9,9,1,0,0,0,1,1,0,0,1,},
            new []{9,9,9,1,0,0,0,0,0,0,0,1,},
            new []{9,9,9,1,1,1,1,1,1,1,1,1,},
        };

        Origin = new Point(0, 0);
    }

    public int GetCellAt(Point point)
    {
        return mapData[point.Y][point.X];
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
                var cellValue = mapData[y][x];
                var cellVisual = cellVisuals[cellValue];
                Console.Write(cellVisual);
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
                if (GetCellAt(point) != 1)
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
}