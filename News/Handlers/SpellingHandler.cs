namespace DesignPatterns.News.Handlers;

public class SpellingHandler : BaseHandler
{
    public override bool Handle(string[] news)
    {
        var rand = new Random();

        if (rand.Next(0, 2) != 0) return base.Handle(news);
        
        Console.WriteLine("SpellingHandler: Spelling error");
        return false;
    }
}