using DesignPatterns.Restaurant;
using DesignPatterns.Restaurant.Foods;

Console.WriteLine("Hello, World!");

var foodOrderingService = FoodOrderingService.Instance;

var capricciosa = foodOrderingService.OrderFood(RestaurantType.Italian, FoodType.Pizza);

var beefStew = foodOrderingService.OrderFood(RestaurantType.American, FoodType.Soup);

var beefStew2 = beefStew.Clone();

var foods = new List<IFood>() { capricciosa, beefStew, beefStew2 };

foreach (var food in foods)
{
    food.PrintDescription();
}