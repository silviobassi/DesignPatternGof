namespace Pattern.Gof.Observer;

public interface ISubscriber
{
    void Update(IPublisher publisher);
}