namespace Pattern.Gof.Strategy;

public class Purchase(AbstractPaymentStrategy paymentStrategy)
{
    private AbstractPaymentStrategy PaymentStrategy => paymentStrategy;

    public void ProcessPayment(double amount) => PaymentStrategy.Pay(amount);
}