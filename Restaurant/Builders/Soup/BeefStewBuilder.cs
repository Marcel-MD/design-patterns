using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Builders.Soup;

public class BeefStewBuilder : ISoupBuilder
{
    private BeefStew? _soup;
    
    public void Reset()
    {
        _soup = null;
    }

    public void PourWater(int ml)
    {
        _soup = new BeefStew(ml);
    }

    public void AddIngredients()
    {
        _soup!.AddIngredient("Beef");
        _soup.AddIngredient("Potato");
        _soup.AddIngredient("Carrot");
        _soup.AddIngredient("Onion");
    }

    public void Cook()
    {
        Console.WriteLine("Cooking soup for 1 hour");
    }

    public ISoup GetSoup()
    {
        return _soup!;
    }
}