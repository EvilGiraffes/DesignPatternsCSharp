namespace Bridge;
public class OnlineStore : Store
{
    public OnlineStore(ICreditCardProcessor cardProcessor) : base(cardProcessor)
    {
    }
    public override void Purchase(CreditCard card, string product, double price)
    {
        Console.WriteLine($"Purchasing from {typeof(OnlineStore).Name}.");
        if (!CardProcessor.Authenticate(card))
        {
            Console.WriteLine("The card was declined.");
            return;
        }
        CardProcessor.Charge(card, price);
        Console.WriteLine($"Purhcased {product} for {price:C3}.");
    }
}
