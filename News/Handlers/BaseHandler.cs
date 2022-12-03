namespace DesignPatterns.News.Handlers;

public class BaseHandler : IHandler
{
    private IHandler _nextHandler;

    public void SetNext(IHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual bool Handle(string[] news)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(news);
        }

        return true;
    }
}