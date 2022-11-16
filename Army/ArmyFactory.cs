using DesignPatterns.Army.Soldier;
using DesignPatterns.Army.Soldier.Equipment;

namespace DesignPatterns.Army;

public static class ArmyFactory
{
    public static ISoldier CreateSoldier(string name, IWeapon weapon, bool hasArmor = false)
    {
        ISoldier soldier = new Soldier.Soldier(name);
        soldier = new WeaponDecorator(soldier, weapon);
        soldier = hasArmor ? new ArmorDecorator(soldier) : soldier;
        
        return soldier;
    }

    public static ISoldier CreateCommander(string name, params ISoldier[] soldiers)
    {
        Commander commander = new Soldier.Commander(name);
        
        foreach (var soldier in soldiers)
        {
            commander.AddSoldier(soldier);
        }
        
        return commander;
    }
}