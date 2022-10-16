using DesignPatterns.Restaurant.Foods.Pizza;

namespace DesignPatterns.Restaurant.Builders.Pizza;

public interface IPizzaBuilder
{
    public void Reset();
    public void SetDoughAndSauce(string dough, string sauce);
    public void AddToppings();
    public void Cook();
    public IPizza GetPizza();
}