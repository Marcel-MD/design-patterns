using DesignPatterns.Army;
using DesignPatterns.News;
using DesignPatterns.News.Strategy;

Console.WriteLine("Hello, World!");

var newspaperPublisher = new NewsPublisher(new NewspaperStrategy());
newspaperPublisher.Subscribe(new Subscriber("John"));
newspaperPublisher.Subscribe(new Subscriber("Jane"));
newspaperPublisher.Subscribe(new Subscriber("Jack"));

newspaperPublisher.Publish(new [] { "News 1", "News 2", "News 3" });

var blogPublisher = new NewsPublisher(new BlogStrategy());
blogPublisher.Subscribe(new Subscriber("John"));
blogPublisher.Subscribe(new Subscriber("Jane"));
blogPublisher.Subscribe(new Subscriber("Jack"));

blogPublisher.Publish(new [] { "News 1", "News 2", "News 3" });