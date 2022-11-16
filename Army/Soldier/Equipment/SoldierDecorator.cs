namespace DesignPatterns.Army.Soldier.Equipment;

public abstract class SoldierDecorator : ISoldier
{
    private ISoldier _soldier;

    public SoldierDecorator(ISoldier soldier)
    {
        _soldier = soldier;
    }

    public virtual string Description()
    {
        return _soldier.Description();
    }

    public virtual string Attack()
    {
        return _soldier.Attack();
    }
}