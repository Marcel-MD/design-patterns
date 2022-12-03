namespace DesignPatterns.News.Handlers;

public class CensorHandler : BaseHandler
{
    public override bool Handle(string[] news)
    {
        var rand = new Random();

        if (rand.Next(0, 2) != 0) return base.Handle(news);
        
        Console.WriteLine("CensorHandler: Censoring this news");
        return false;
    }
}