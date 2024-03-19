class Player
{
    public int Hp 
    { 
        get => hp;
        set => hp = Math.Clamp(value, 0, MaxHp);
    }
    int hp = 90;
    public int MaxHp { get; set; } = 100;

    public int X {get; set;}
    public int Y {get; set;}

    // TODO: Should it return hp after heal?
    public void Heal()
    {
        Console.WriteLine("Healing!");
        Hp += 10;
    }

    public void Move()
    {
        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        if (pressedKey.Key == ConsoleKey.A)
        {
            X -= 1;
        }
        else if(pressedKey.Key == ConsoleKey.D)
        {
            X += 1;
        }
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