namespace Pattern.Gof.Observer;

public sealed class CustomerSubscriber(string name, string email) : ISubscriber
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;

    public void Update(IPublisher publisher)
    {
        if (publisher is SchedulePublisher schedulePublisher)
        {
            Console.WriteLine(
                $"👨 CustomerSubscriber {Name}, email: {Email} notified: {schedulePublisher.Date} at {schedulePublisher.Location}");
            return;
        }

        Console.WriteLine($"👨 Customer {Name}, email {Email} notified: {publisher}");
    }
}