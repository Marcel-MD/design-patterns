namespace DesignPatterns.News.Strategy;

public class BlogStrategy : IPublishStrategy
{
    public void Publish(string[] news, ISubscriber[] subscribers)
    {
        Console.WriteLine("Writing news to blog");
        Console.WriteLine("Deploying blog");
        foreach (var s in subscribers)
        {
            s.Receive(news);
        }
    }
}