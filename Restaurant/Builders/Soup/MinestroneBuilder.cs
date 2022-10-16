using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Builders.Soup;

public class MinestroneBuilder : ISoupBuilder
{
    private MinestroneSoup? _soup;
    
    public void Reset()
    {
        _soup = null;
    }

    public void PourWater(int ml)
    {
        _soup = new MinestroneSoup(ml);
    }

    public void AddIngredients()
    {
        _soup!.AddIngredient("Carrot");
        _soup.AddIngredient("Onion");
        _soup.AddIngredient("Celery");
        _soup.AddIngredient("Tomato");
        _soup.AddIngredient("Pasta");
        _soup.AddIngredient("Cabbage");
        _soup.AddIngredient("Garlic");
        _soup.AddIngredient("Parsley");
        _soup.AddIngredient("Salt");
        _soup.AddIngredient("Pepper");
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