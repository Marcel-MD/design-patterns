using DesignPatterns.News.SubscriberState;

namespace DesignPatterns.News;

public class Subscriber : ISubscriber
{
    private IState _state;
    private string[] _news;
    
    public string Name { get; }

    public Subscriber(string name)
    {
        Name = name;
        _state = new FreeState(this);
    }
    
    public void Receive(string[] news)
    {
        _news = news;
        _state.Receive(news);
    }

    public void UpdateState(IState state)
    {
        _state = state;
    }
}