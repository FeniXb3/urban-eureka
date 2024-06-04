class StaticEnemy : Enemy
{
    public StaticEnemy(string visual, Point startingPosition) : base(visual, startingPosition)
    {
    }

    public override Point GetNextPosition()
    {
        return Position;
    }
}