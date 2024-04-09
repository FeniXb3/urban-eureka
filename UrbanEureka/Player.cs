class Player
{
    public int Hp 
    { 
        get => hp;
        set => hp = Math.Clamp(value, 0, MaxHp);
    }
    int hp = 90;
    public int MaxHp { get; set; } = 100;
    public Point Position { get; set; }

    private Dictionary<ConsoleKey, Point> directions = new()
    {
        { ConsoleKey.A, new Point(-1, 0)}
    };

    public Player(int x, int y)
    {
        Position = new Point(x, y);
    }

    public Player(Point startingPosition)
    {
        // Position = new Point(startingPosition.X, startingPosition.Y);
        Position = new Point(startingPosition);
        // directions.Add(ConsoleKey.A, new Point(-1, 0));
        // directions.Add(ConsoleKey.A, new Point(1, 0));
        // directions[ConsoleKey.A] = new Point(-1, 0);
        // directions[ConsoleKey.A] = new Point(1, 0);
        directions[ConsoleKey.D] = new Point(1, 0);
        directions[ConsoleKey.W] = new Point(0, -1);
        directions[ConsoleKey.S] = new Point(0, 1);
        directions[ConsoleKey.E] = new Point(1, -1);
    }
    
    //Copy constructor
    public Player(Player other)
    {
        MaxHp = other.MaxHp;
        Hp = other.Hp;
        Position = new Point(other.Position);
    }


    // TODO: Should it return hp after heal?
    public void Heal(int amount)
    {
        Console.WriteLine("Healing!");
        Hp += amount;
    }

    public void Move()
    {
        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        // zmienna[klawisz] = kierunek
        if (directions.ContainsKey(pressedKey.Key))
        {
            Point direction = directions[pressedKey.Key];
            Position.X += direction.X;
            Position.Y += direction.Y;
        }

        // if (pressedKey.Key == ConsoleKey.A)
        // {
        //     Position.X -= 1;
        // }
        // else if(pressedKey.Key == ConsoleKey.D)
        // {
        //     Position.X += 1;
        // }
    }
}

/*
Player
    data:
    - hp
    - maxhp
    - mana
    - maxmana

    - int
    - dex
    - str
    - position
        - x
        - y
        - z

    actions:
    - move
    - die
    - heal
    - attack
    - dash


*/

/*
Owca
- ilosc futra
- dzieci - lista Owiec
- Narodziny() -> Owca
{
    Owca dziecko = new Owca()
    dzieci.Add(dziecko)
    dzieci.Add(new Owca());
}

*/