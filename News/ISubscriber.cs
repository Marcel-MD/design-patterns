using DesignPatterns.News.SubscriberState;

namespace DesignPatterns.News;

public interface ISubscriber
{
    string Name { get; }
    void Receive(string[] news);
    void UpdateState(IState state);
}