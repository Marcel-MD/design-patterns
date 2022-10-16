using DesignPatterns.Restaurant.Foods.Soup;

namespace DesignPatterns.Restaurant.Builders.Soup;

public interface ISoupBuilder
{
    public void Reset();
    public void PourWater(int ml);
    public void AddIngredients();
    public void Cook();
    public ISoup GetSoup();
}