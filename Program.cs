using System;

interface ISocialNetwork
{
    void Post(string message);
}

class ExistingSystem
{
    private ISocialNetwork socialNetwork;

    public ExistingSystem(ISocialNetwork socialNetwork)
    {
        this.socialNetwork = socialNetwork;
    }

    public void Publish(string text)
    {
        socialNetwork.Post(text);
    }
}

class FacebookApi
{
    public void SendPost(string text)
    {
        Console.WriteLine("Facebook | Новий пост успішно опубліковано");
        Console.WriteLine("Повідомлення: " + text);
        Console.WriteLine();
    }
}

class TwitterApi
{
    public void Tweet(string text)
    {
        Console.WriteLine("Twitter | Твіт успішно надіслано");
        Console.WriteLine("Повідомлення: " + text);
        Console.WriteLine();
    }
}

class FacebookAdapter : ISocialNetwork
{
    private FacebookApi facebook;

    public FacebookAdapter(FacebookApi facebook)
    {
        this.facebook = facebook;
    }

    public void Post(string message)
    {
        facebook.SendPost(message);
    }
}

class TwitterAdapter : ISocialNetwork
{
    private TwitterApi twitter;

    public TwitterAdapter(TwitterApi twitter)
    {
        this.twitter = twitter;
    }

    public void Post(string message)
    {
        twitter.Tweet(message);
    }
}

class Program
{
    static void Main()
    {
        FacebookApi facebookApi = new FacebookApi();
        TwitterApi twitterApi = new TwitterApi();

        ISocialNetwork facebook = new FacebookAdapter(facebookApi);
        ISocialNetwork twitter = new TwitterAdapter(twitterApi);

        ExistingSystem system1 = new ExistingSystem(facebook);
        ExistingSystem system2 = new ExistingSystem(twitter);

        system1.Publish("Сьогоднішні новини вражають!");
        system2.Publish("Автомобіль моєї мрії!");
    }
}
