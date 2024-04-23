﻿// See https://aka.ms/new-console-template for more information
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

/*

###########
#.........#
#.........#
#.........#
#.........#
#.........#
###########

*/
// string map = @"###########
// #.........#
// #.........#
// #.........#
// #.........#
// #.........#
// ###########";

string[] map = {
    "###########",
    "#.........#",
    "#.........#",
    "#.........#",
    "#.........#",
    "#.........#",
    "###########"
};

Console.Clear();

foreach (string row in map)
{
    Console.WriteLine(row);
}

Console.SetCursorPosition(hero.Position.X, hero.Position.Y);
Console.Write("@");

while (true)
{
    hero.Move();

    string previousRow = map[hero.PreviousPosition.Y];
    char previousCell = previousRow[hero.PreviousPosition.X];
    Console.SetCursorPosition(hero.PreviousPosition.X, hero.PreviousPosition.Y);
    Console.Write(previousCell);

    Console.SetCursorPosition(hero.Position.X, hero.Position.Y);
    Console.Write("@");
}