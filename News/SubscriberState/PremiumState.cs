namespace DesignPatterns.News.SubscriberState;

public class PremiumState : IState
{
    private readonly ISubscriber _subscriber;
    
    public PremiumState(ISubscriber subscriber)
    {
        _subscriber = subscriber;
    }
    
    public void Receive(string[] news)
    {
        Console.WriteLine("Premium subscriber received news: {0}", string.Join(", ", news));
        
        var rand = new Random();
        if (rand.Next(0, 100) >= 10) return;
        _subscriber.UpdateState(new FreeState(_subscriber));
        Console.WriteLine("Premium subscriber {0} downgraded to free", _subscriber.Name);
    }
}