public class Player
{
    int health = 10000;
    public void Damage(int baseDamage, IEnchantmentStrategy enchantment)
    {
        health -= baseDamage;
        health -= enchantment.Damage();
    }
    public override string ToString()
    {
        return $"Current health is {health}";
    }
}