namespace DesignPatterns.Army.Soldier.Equipment;

public class ArmorDecorator : SoldierDecorator
{
    public ArmorDecorator(ISoldier soldier) : base(soldier) { }

    public override string Description()
    {
        return base.Description() + " with armor";
    }
}