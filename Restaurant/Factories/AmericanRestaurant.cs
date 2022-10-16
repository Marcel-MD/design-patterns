using DesignPatterns.Restaurant.Builders.Pizza;
using DesignPatterns.Restaurant.Builders.Soup;
using DesignPatterns.Restaurant.Foods.Pizza;
using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Factories;

public class AmericanRestaurant : IRestaurant
{
    private readonly IPizzaBuilder _pizzaBuilder;
    private readonly ISoupBuilder _soupBuilder;

    public AmericanRestaurant()
    {
        _pizzaBuilder = new CaliforniaPizzaBuilder();
        _soupBuilder = new BeefStewBuilder();
    }

    public IPizza CreatePizza()
    {
        _pizzaBuilder.Reset();
        _pizzaBuilder.SetDoughAndSauce("thick", "tomato");
        _pizzaBuilder.AddToppings();
        _pizzaBuilder.Cook();
        return _pizzaBuilder.GetPizza();
    }

    public ISoup CreateSoup()
    {
        _soupBuilder.Reset();
        _soupBuilder.PourWater(400);
        _soupBuilder.AddIngredients();
        _soupBuilder.Cook();
        return _soupBuilder.GetSoup();
    }
}