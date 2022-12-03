namespace DesignPatterns.News.Strategy;

public class NewspaperStrategy : IPublishStrategy
{
    public void Publish(string[] news, ISubscriber[] subscribers)
    {
        Console.WriteLine("Printing newspaper...");
        Console.WriteLine("Delivering newspaper...");
        foreach (var s in subscribers)
        {
            s.Receive(news);
        }
    }
}