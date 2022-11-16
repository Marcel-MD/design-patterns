using DesignPatterns.Army.Soldier;
using DesignPatterns.Army.Soldier.Equipment;

namespace DesignPatterns.Army;

public static class BigRedButton
{
    private const string _password = "1234";
    
    public static void Press(string password)
    {
        if (password != _password)
        {
            Console.WriteLine("Wrong password!");
        }
        
        var random = new Random();

        var supremeCommander = new Commander("Supreme Commander");

        for (int i = 0; i < 3; i++)
        {
            var commander = new Commander($"Commander {i}");
            for(int j = 0; j < 10; j++)
            {
                IWeapon weapon = random.Next(2) == 0 ? new Gun() : new Knife();
                ISoldier s = new Soldier.Soldier($"Soldier {j}");
                s = new WeaponDecorator(s, weapon);
                
                commander.AddSoldier(s);
            }
            
            supremeCommander.AddSoldier(commander);
        }
        
        Console.WriteLine(supremeCommander.Attack());
    }
}