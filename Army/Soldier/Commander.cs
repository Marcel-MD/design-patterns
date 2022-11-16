namespace DesignPatterns.Army.Soldier;

public class Commander : ISoldier
{
    private readonly string _name;

    private readonly List<ISoldier> _subordinates = new();
    
    public Commander(string name)
    {
        _name = name;
    }

    public void AddSoldier(ISoldier soldier)
    {
        _subordinates.Add(soldier);
    }

    public void RemoveSoldier(ISoldier soldier)
    {
        _subordinates.Remove(soldier);
    }
    
    public string Description()
    {
        return $"{_name}: I am a commander ";
    }

    public string Attack()
    {
        var attack = $"{_name}: I am attacking with my soldiers:\n";
        foreach (var subordinate in _subordinates)
        {
            attack += $"{subordinate.Attack()}\n";
        }

        return attack;
    }
}