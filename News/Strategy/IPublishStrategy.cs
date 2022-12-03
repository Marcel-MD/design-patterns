namespace DesignPatterns.News.Strategy;

public interface IPublishStrategy
{
    void Publish(string[] news, ISubscriber[] subscribers);
}