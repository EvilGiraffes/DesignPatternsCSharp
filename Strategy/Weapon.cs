public class Weapon
{
    int _baseDamage;
    IEnchantmentStrategy _enchantment;
    public Weapon(int baseDamage, IEnchantmentStrategy enchantment)
    {
        _baseDamage = baseDamage;
        _enchantment = enchantment;
    }
    public void Damage(Player player) => player.Damage(_baseDamage, _enchantment);
}