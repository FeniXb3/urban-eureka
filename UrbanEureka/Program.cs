// See https://aka.ms/new-console-template for more information
Console.CursorVisible = false;

Console.WriteLine("Hello, World!");
Console.WriteLine("Urban Eureka, wow!!!!");
Console.WriteLine("Goodbye, World!");
// Player hero = new Player(10, 3);
Point playerPosition = new Point(10, 3);
Player hero = new Player(playerPosition);
playerPosition.X = 0;

Console.WriteLine(hero.Hp);
hero.Hp = 90;
Console.WriteLine(hero.Hp);
int healAmount = 10;
hero.Heal(healAmount);
healAmount = 20;
hero.Heal(healAmount);
Console.WriteLine(hero.Hp);
hero.Hp = 9001;

Console.WriteLine(hero.Hp);
hero.Hp = -10;
Console.WriteLine(hero.Hp);

Map map = new Map();

Console.Clear();

map.Display(new Point(2, 3));

map.DrawSomethingAt(hero.Visual, hero.Position);

// Console.SetCursorPosition(hero.Position.X + map.Origin.X, hero.Position.Y + map.Origin.Y);
// Console.Write("@");

while (true)
{
    Point nextPosition = hero.GetNextPosition();
    if (!map.IsPointCorrect(nextPosition))
    {
        continue;
    }

    hero.Move(nextPosition);
    
    // var previousCell = map.GetCellVisualAt(hero.PreviousPosition);
    // map.DrawSomethingAt(previousCell, hero.PreviousPosition);
    map.RedrawCellAt(hero.PreviousPosition);
    map.DrawSomethingAt(hero.Visual, hero.Position);

    // Console.SetCursorPosition(hero.PreviousPosition.X + map.Origin.X, hero.PreviousPosition.Y + map.Origin.Y);
    // Console.Write(previousCell);

    // Console.SetCursorPosition(hero.Position.X + map.Origin.X, hero.Position.Y + map.Origin.Y);
    // Console.Write("@");
}