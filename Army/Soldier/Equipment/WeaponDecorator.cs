namespace DesignPatterns.Army.Soldier.Equipment;

public class WeaponDecorator : SoldierDecorator
{
    private readonly IWeapon _weapon;

    public WeaponDecorator(ISoldier soldier, IWeapon weapon) : base(soldier)
    {
        _weapon = weapon;
    }
    
    public override string Attack()
    {
        return $"{base.Attack()} {_weapon.Attack()},";
    }
}