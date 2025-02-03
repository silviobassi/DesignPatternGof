namespace Pattern.Gof.Observer;

public sealed class SchedulePublisher(DateTime date, string location) : IPublisher
{
    public DateTime Date { get; set; } = date;
    public string Location { get; set; } = location;

    private IList<ISubscriber> Listeners { get; } = [];

    public void Subscribe(ISubscriber subscriber)
    {
        Console.WriteLine("🔗 Subject: Attached an subscriber.");
        Listeners.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        Console.WriteLine("🔗 Subject: Detached an subscriber.");
        Listeners.Remove(subscriber);
    }

    public void Notify()
    {
        Console.WriteLine("🔔 Subject: Notifying observers...");

        foreach (var listener in Listeners)
        {
            listener.Update(this);
        }
    }
}