namespace DesignPatterns.Restaurant.Foods;

public interface IFood
{
    public void PrintDescription();

    public IFood Clone();
}