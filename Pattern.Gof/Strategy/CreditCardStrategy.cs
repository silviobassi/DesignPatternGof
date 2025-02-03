namespace Pattern.Gof.Strategy;

public sealed class CreditCardStrategy(string cardNumber, string cardHolder, string expiryDate, string cvv)
    : AbstractPaymentStrategy
{
    public string CardNumber { get; set; } = cardNumber;
    public string CardHolder { get; set; } = cardHolder;
    public string ExpiryDate { get; set; } = expiryDate;
    public string Cvv { get; set; } = cvv;

    protected internal override void Pay(double amount)
    {
        Console.WriteLine(
            $"💳 Processing credit card payment for {amount}. " +
            $"Card Number: {CardNumber}, Card Holder: {CardHolder}, Expiry Date: {ExpiryDate}, CVV: {Cvv}.");
    }
}