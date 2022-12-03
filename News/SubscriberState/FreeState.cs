namespace DesignPatterns.News.SubscriberState;

public class FreeState : IState
{
    private readonly ISubscriber _subscriber;
    
    public FreeState(ISubscriber subscriber)
    {
        this._subscriber = subscriber;
    }
    
    public void Receive(string[] news)
    {
        Console.WriteLine("Free subscriber {0} received news: {1}", _subscriber.Name, string.Join(", ", news));

        var rand = new Random();
        if (rand.Next(0, 100) >= 10) return;
        _subscriber.UpdateState(new PremiumState(_subscriber));
        Console.WriteLine("Free subscriber {0} upgraded to premium", _subscriber.Name);
    }
}