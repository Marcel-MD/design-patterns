using DesignPatterns.Restaurant.Foods.Pizza;
using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Factories;

public interface IRestaurant
{
    IPizza CreatePizza();
    ISoup CreateSoup();
}