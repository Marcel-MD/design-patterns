namespace DesignPatterns.News.Handlers;

public interface IHandler
{
    void SetNext(IHandler handler);
    bool Handle(string[] news);
}