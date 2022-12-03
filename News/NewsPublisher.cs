using DesignPatterns.News.Handlers;
using DesignPatterns.News.Strategy;

namespace DesignPatterns.News;

public class NewsPublisher
{
    private readonly IPublishStrategy _publishStrategy;
    private readonly List<ISubscriber> _subscribers;
    private readonly IHandler _handler;
    
    public NewsPublisher(IPublishStrategy publishStrategy)
    {
        _publishStrategy = publishStrategy;
        _subscribers = new List<ISubscriber>();
        _handler = new SpellingHandler();
        _handler.SetNext(new CensorHandler());
    }
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }
    
    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Publish(string[] news)
    {
        if (_handler.Handle(news))
        {
            _publishStrategy.Publish(news, _subscribers.ToArray());   
        }
    }
}