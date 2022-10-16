using DesignPatterns.Restaurant.Factories;
using DesignPatterns.Restaurant.Foods;

namespace DesignPatterns.Restaurant;

public class FoodOrderingService
{
    private static readonly FoodOrderingService _instance = new FoodOrderingService();
    public static FoodOrderingService Instance => _instance;

    private readonly ItalianRestaurant _italianRestaurant = new ItalianRestaurant();
    private readonly AmericanRestaurant _americanRestaurant = new AmericanRestaurant();

    public IFood OrderFood(RestaurantType restaurantType, FoodType foodType)
    {
        IRestaurant restaurant = restaurantType switch
        {
            RestaurantType.Italian => _italianRestaurant,
            RestaurantType.American => _americanRestaurant,
            _ => throw new ArgumentOutOfRangeException(nameof(restaurantType), restaurantType, null)
        };
        
        IFood food = foodType switch
        {
            FoodType.Pizza => restaurant.CreatePizza(),
            FoodType.Soup => restaurant.CreateSoup(),
            _ => throw new ArgumentOutOfRangeException(nameof(foodType), foodType, null)
        };
        
        return food;
    }
    
    static FoodOrderingService()
    {
    }

    private FoodOrderingService()
    {
    }
}

public enum RestaurantType
{
    American,
    Italian,
}

public enum FoodType
{
    Pizza,
    Soup
}
