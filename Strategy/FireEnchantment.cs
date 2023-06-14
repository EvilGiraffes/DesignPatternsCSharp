public class FireEnchantment: IEnchantmentStrategy
{
    int _damage;
    int _incrementAmount;
    public FireEnchantment(int startDamage, int incrementAmount)
    {
        _damage = startDamage;
        _incrementAmount = incrementAmount;
    }
    public int Damage()
    {
        _damage += _incrementAmount;
        return _damage;
    }
}