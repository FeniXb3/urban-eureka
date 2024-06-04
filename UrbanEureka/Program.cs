Console.CursorVisible = false;

Point playerPosition = new Point(10, 3);
Player hero = new Player("@", playerPosition);

ComposedPlayer composedPlayer = new ComposedPlayer("@", playerPosition);

ComposedEnemy composedEnemy = new ComposedEnemy("T", new Point(4, 4)); 

// Player anotherHero = new Player("Q", new Point(2, 1));

Enemy troll = new Enemy("T", new Point(4, 4));

Character[] characters = new Character[] 
{
    hero,
    // anotherHero,
    troll,
    new StaticEnemy("D", new Point(5, 5))
};

Map map = new Map();
Point mapOrigin = new Point(15, 3);
Console.Clear();

if (map.Size.X + mapOrigin.X >= 0 && map.Size.X + mapOrigin.X < Console.BufferWidth
    && map.Size.Y + mapOrigin.Y >=0 && map.Size.Y + mapOrigin.Y < Console.BufferHeight)
{
    map.Display(mapOrigin);

    map.DrawSomethingAt(composedPlayer.VisualComponent.Visual, composedPlayer.PositionComponent.Position);
    map.DrawSomethingAt(composedEnemy.VisualComponent.Visual, composedEnemy.PositionComponent.Position);

    // foreach (var character in characters)
    // {
    //     map.DrawSomethingAt(character.Visual, character.Position);
    // }

    while (true)
    {
        Point nextPosition = composedPlayer.Movement.GetNextPosition();
        if (map.IsPointCorrect(nextPosition))
        {
            composedPlayer.Movement.Move(nextPosition);

            map.RedrawCellAt(composedPlayer.Movement.PreviousPosition);
            map.DrawSomethingAt(composedPlayer.VisualComponent.Visual, composedPlayer.PositionComponent.Position);
        }

        nextPosition = composedEnemy.Movement.GetNextPosition();
        if (map.IsPointCorrect(nextPosition))
        {
            composedEnemy.Movement.Move(nextPosition);

            map.RedrawCellAt(composedEnemy.Movement.PreviousPosition);
            map.DrawSomethingAt(composedEnemy.VisualComponent.Visual, composedEnemy.PositionComponent.Position);
        }

        // foreach (var character in characters)
        // {
        //     Point nextPosition = character.GetNextPosition();
        //     if (map.IsPointCorrect(nextPosition))
        //     {
        //         character.Move(nextPosition);
                
        //         map.RedrawCellAt(character.PreviousPosition);
        //         map.DrawSomethingAt(character.Visual, character.Position);
        //     }
        // }
    }
}
else
{
    Console.WriteLine("Terminal window is to small, make it bigger");
}