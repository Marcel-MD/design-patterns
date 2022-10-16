using DesignPatterns.Restaurant.Foods.Pizza;

namespace DesignPatterns.Restaurant.Builders.Pizza;

public class CapricciosaPizzaBuilder : IPizzaBuilder
{
    private CapricciosaPizza? _pizza;
    
    public void Reset()
    {
        _pizza = null;
    }

    public void SetDoughAndSauce(string dough, string sauce)
    {
        _pizza = new CapricciosaPizza(dough, sauce);
    }

    public void AddToppings()
    {
        _pizza!.AddTopping("Mozzarella");
        _pizza.AddTopping("Ham");
        _pizza.AddTopping("Mushrooms");
        _pizza.AddTopping("Artichokes");
    }

    public void Cook()
    {
        Console.WriteLine("Cooking pizza for 25 minutes at 350");
    }

    public IPizza GetPizza()
    {
        return _pizza!;
    }
}