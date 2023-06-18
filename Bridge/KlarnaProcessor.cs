namespace Bridge;
public sealed class KlarnaProcessor : ICreditCardProcessor
{
    public bool Authentic { get; set; } = true;
    public bool Authenticate(CreditCard card)
    {
        Console.WriteLine($"{typeof(KlarnaProcessor)} is authenticating {card}.");
        return Authentic;
    }
    public void Charge(CreditCard card, double amount)
    {
        Console.WriteLine($"Charging {card} with {amount:C3}.");
    }
}
