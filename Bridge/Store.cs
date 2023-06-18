namespace Bridge;
public abstract class Store
{
    protected ICreditCardProcessor CardProcessor { get; }
    protected Store(ICreditCardProcessor cardProcessor)
    {
        CardProcessor = cardProcessor;
    }
    public abstract void Purchase(CreditCard card, string product, double price);
}
