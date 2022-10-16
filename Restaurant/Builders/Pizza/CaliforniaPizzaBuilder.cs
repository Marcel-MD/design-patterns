using DesignPatterns.Restaurant.Foods.Pizza;

namespace DesignPatterns.Restaurant.Builders.Pizza;

public class CaliforniaPizzaBuilder : IPizzaBuilder
{
    private CaliforniaPizza? _pizza;

    public void Reset()
    {
        _pizza = null;
    }

    public void SetDoughAndSauce(string dough, string sauce)
    {
        _pizza = new CaliforniaPizza(dough, sauce);
    }

    public void AddToppings()
    {
        _pizza!.AddTopping("Mozzarella");
        _pizza.AddTopping("Parmesan");
        _pizza.AddTopping("Oregano");
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