namespace DesignPatterns.News.SubscriberState;

public interface IState
{
    public void Receive(string[] news);
}