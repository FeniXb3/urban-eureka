Console.CursorVisible = false;

Point playerPosition = new Point(10, 3);
Player hero = new Player("@", playerPosition);

Player anotherHero = new Player("Q", new Point(2, 1));

Enemy troll = new Enemy("T", new Point(4, 4));

Character[] characters = new Character[] 
{
    hero,
    anotherHero,
    troll
};

Map map = new Map();
Point mapOrigin = new Point(15, 3);
Console.Clear();

if (map.Size.X + mapOrigin.X >= 0 && map.Size.X + mapOrigin.X < Console.BufferWidth
    && map.Size.Y + mapOrigin.Y >=0 && map.Size.Y + mapOrigin.Y < Console.BufferHeight)
{
    map.Display(mapOrigin);

    foreach (var character in characters)
    {
        map.DrawSomethingAt(character.Visual, character.Position);
    }

    while (true)
    {
        foreach (var character in characters)
        {
            Point nextPosition = character.GetNextPosition();
            if (map.IsPointCorrect(nextPosition))
            {
                character.Move(nextPosition);
                
                map.RedrawCellAt(character.PreviousPosition);
                map.DrawSomethingAt(character.Visual, character.Position);
            }
        }
    }
}
else
{
    Console.WriteLine("Terminal window is to small, make it bigger");
}