namespace DesignPatterns.Restaurant.Foods.Pizza;

public class CaliforniaPizza : IPizza
{
    private readonly string _dough;
    private readonly string _sauce;
    private List<string> _toppings;
    private readonly string _name;

    public CaliforniaPizza(string dough, string sauce)
    {
        _dough = dough;
        _sauce = sauce;
        _toppings = new List<string>();
        _name = "California Pizza";
    }
    
    public void AddTopping(string topping)
    {
        _toppings.Add(topping);
    }

    public void PrintDescription()
    {
        Console.WriteLine($"===== {_name} =====");
        Console.WriteLine($"Dough: {_dough}");
        Console.WriteLine($"Sauce: {_sauce}");
        Console.WriteLine("Toppings: ");
        foreach (var topping in _toppings)
        {
            Console.WriteLine($"- {topping}");
        }
    }

    public IFood Clone()
    {
        var clone = (CaliforniaPizza) MemberwiseClone();
        clone._toppings = new List<string>(_toppings);
        return clone;
    }
}