namespace DesignPatterns.Army.Soldier;

public class Soldier : ISoldier
{
    private readonly string _name;
    
    public Soldier(string name)
    {
        _name = name;
    }
    
    public string Description()
    {
        return $"{_name}: I am a soldier ";
    }

    public string Attack()
    {
        return $"{_name}: I am attacking: ";
    }
}