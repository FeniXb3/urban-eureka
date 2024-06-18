internal class HealthComponent
{   public int Hp 
    { 
        get => hp;
        set => hp = Math.Clamp(value, 0, MaxHp);
    }
    int hp = 90;
    public int MaxHp { get; set; } = 100;

    // TODO: Should it return hp after heal?
    public void Heal(int amount)
    {
        Console.WriteLine("Healing!");
        Hp += amount;
    }

    public void TakeDamage(int amount)
    {
        Hp -= amount;
    }
}