namespace Pattern.Gof.Observer;

public sealed class ProfessionalSubscriber(string name, string email) : ISubscriber
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;

    public void Update(IPublisher publisher)
    {
        if (publisher is SchedulePublisher schedulePublisher)
        {
            Console.WriteLine(
                $"👨🏻 ProfessionalSubscriber {Name}, email: {Email} notified: {schedulePublisher.Date} at {schedulePublisher.Location}");
            return;
        }

        Console.WriteLine($"😀 Professional {Name}, email {Email} notified: {publisher}");
    }
}