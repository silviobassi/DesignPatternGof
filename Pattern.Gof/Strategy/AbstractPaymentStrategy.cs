namespace Pattern.Gof.Strategy;

public abstract class AbstractPaymentStrategy
{
    protected internal abstract void Pay(double amount);
}
