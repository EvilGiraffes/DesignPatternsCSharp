namespace Bridge;
public interface ICreditCardProcessor
{
    bool Authenticate(CreditCard card);
    void Charge(CreditCard card, double amount);
}
