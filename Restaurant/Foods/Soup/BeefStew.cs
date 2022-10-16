namespace DesignPatterns.Restaurant.Foods.Soup;

public class BeefStew : ISoup
{
    private readonly int _mlOfWater;
    private List<string> _ingredients;
    private readonly string _name;
    
    public BeefStew(int mlOfWater)
    {
        _mlOfWater = mlOfWater;
        _ingredients = new List<string>();
        _name = "Beef Stew";
    }

    public void PrintDescription()
    {
        Console.WriteLine($"===== {_name} =====");
        Console.WriteLine($"Quantity: {_mlOfWater}ml");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in _ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
    }
    
    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public IFood Clone()
    {
        var clone = new BeefStew(_mlOfWater)
        {
            _ingredients = new List<string>(_ingredients)
        };
        return clone;
    }
}