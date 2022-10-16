namespace DesignPatterns.Restaurant.Foods.Pizza;

public interface IPizza : IFood
{
    void AddTopping(string topping);
}