Console.CursorVisible = false;

Point playerPosition = new Point(10, 3);
Player hero = new Player(playerPosition);
Map map = new Map();

Console.Clear();

try
{
    map.Display(new Point(15, 3));
        
    map.DrawSomethingAt(hero.Visual, hero.Position);

    while (true)
    {
        Point nextPosition = hero.GetNextPosition();
        if (!map.IsPointCorrect(nextPosition))
        {
            continue;
        }

        hero.Move(nextPosition);
        
        map.RedrawCellAt(hero.PreviousPosition);
        map.DrawSomethingAt(hero.Visual, hero.Position);
    }
}
catch (ArgumentOutOfRangeException exception)
{
    Console.WriteLine("Terminal window is to small, make it bigger");
}


