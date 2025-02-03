namespace Pattern.Gof.Strategy;

public sealed class PixStrategy(string key, string name, string bank)
    : AbstractPaymentStrategy
{
    public string Key { get; private set; } = key;
    public string Name { get; private set; } = name;
    public string Bank { get; private set; } = bank;
    public string Cpf { get; private set; } = string.Empty;
    public string Cnpj { get; private set; } = string.Empty;
    public string Cellphone { get; private set; } = string.Empty;

    protected internal override void Pay(double amount)
    {
        Console.WriteLine(
            $"💸 Processing PIX payment for {amount}. " +
            $"Key: {Key}, Name: {Name}, Bank: {Bank}, CPF: {Cpf}, CNPJ: {Cnpj}, Cellphone: {Cellphone}.");
    }
}