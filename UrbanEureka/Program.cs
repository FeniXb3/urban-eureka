Console.CursorVisible = false;

Point playerPosition = new Point(10, 3);
Player hero = new Player("@", playerPosition);

Player anotherHero = new Player("Q", new Point(2, 1));

Map map = new Map();
Point mapOrigin = new Point(15, 3);
Console.Clear();

if (map.Size.X + mapOrigin.X >= 0 && map.Size.X + mapOrigin.X < Console.BufferWidth
    && map.Size.Y + mapOrigin.Y >=0 && map.Size.Y + mapOrigin.Y < Console.BufferHeight)
{
    map.Display(mapOrigin);
        
    map.DrawSomethingAt(hero.Visual, hero.Position);
    map.DrawSomethingAt(anotherHero.Visual, anotherHero.Position);


    while (true)
    {
        Point nextPosition = hero.GetNextPosition();
        if (map.IsPointCorrect(nextPosition))
        {
            hero.Move(nextPosition);
            
            map.RedrawCellAt(hero.PreviousPosition);
            map.DrawSomethingAt(hero.Visual, hero.Position);
        }

        //-------
        Point anotherNextPosition = anotherHero.GetNextPosition();
        if (map.IsPointCorrect(anotherNextPosition))
        {
            anotherHero.Move(anotherNextPosition);
            
            map.RedrawCellAt(anotherHero.PreviousPosition);
            map.DrawSomethingAt(anotherHero.Visual, anotherHero.Position);
        }

       
    }
}
else
{
    Console.WriteLine("Terminal window is to small, make it bigger");
}