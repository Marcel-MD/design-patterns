using DesignPatterns.Restaurant.Builders.Pizza;
using DesignPatterns.Restaurant.Builders.Soup;
using DesignPatterns.Restaurant.Foods.Pizza;
using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Factories;

public class ItalianRestaurant : IRestaurant
{
    private readonly IPizzaBuilder _pizzaBuilder;
    private readonly ISoupBuilder _soupBuilder;

    public ItalianRestaurant()
    {
        _pizzaBuilder = new CapricciosaPizzaBuilder();
        _soupBuilder = new MinestroneBuilder();
    }

    public IPizza CreatePizza()
    {
        _pizzaBuilder.Reset();
        _pizzaBuilder.SetDoughAndSauce("thin", "tomato");
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