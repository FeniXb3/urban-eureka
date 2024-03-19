// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Urban Eureka, wow!!!!");
Console.WriteLine("Goodbye, World!");

Player hero = new Player();
Console.WriteLine(hero.Hp);
hero.Hp = 90;
Console.WriteLine(hero.Hp);
hero.Heal();
hero.Heal();
Console.WriteLine(hero.Hp);
hero.Hp = 9001;

Console.WriteLine(hero.Hp);
hero.Hp = -10;
Console.WriteLine(hero.Hp);
while (true)
{
    Console.Clear();
    // Console.WriteLine($"X: {hero.X} Y: {hero.Y}");
    Console.SetCursorPosition(hero.X, hero.Y);
    Console.Write("@");
    hero.Move();
}