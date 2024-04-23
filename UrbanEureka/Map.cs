public class Map
{
    private string[] mapData;

    public Map()
    {
        mapData = new string[] {
            "###########",
            "#.........#",
            "#.........#",
            "#.........#",
            "#.........#",
            "#.........#",
            "###########"
        };
    }

    public char GetCellAt(Point point)
    {
        string previousRow = mapData[point.Y];
        char previousCell = previousRow[point.X];
    
        return previousCell;
    }

    public void Display()
    {
        foreach (string row in mapData)
        {
            Console.WriteLine(row);
        }
    }
}