using System;
/// <summary>
/// Delegate to track hp of player
/// </summary>
/// <param name="amount">Amount of hp affected</param>
public delegate void CalculateHealth(float amount);
/// <summary>
/// Delegate to modify base value of damage
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary>
/// enum containing values for modifying base values
/// </summary>
public enum Modifier
{
    /// <summary>
    /// attack is half of base value
    /// </summary>
    Weak,
    /// <summary>
    /// attack is base value
    /// </summary>
    Base,
    /// <summary>
    /// attack is 1.5x base value
    /// </summary>
    Strong
}
/// <summary>
/// Cretes public class called `Player`
/// </summary>
class Player
{
    // public delegate void CalculateHealth(float amount);
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// Constructor to assign parameters to properties
    /// </summary>
    /// <param name="name">Player name</param>
    /// <param name="maxHp">Maximum Player health points (hp)</param>
    public Player(
        string name = "Player",
        float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }
    /// <summary>
    /// Changes base modifier
    /// </summary>
    /// <param name="baseValue">New base value</param>
    /// <param name="modifier">Enum ref for attack strength</param>
    /// <returns>Modified value</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }
    /// <summary>
    /// Deducts health points of player
    /// </summary>
    /// <param name="damage">Amount to deduct</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }
    /// <summary>
    /// Increases health points of player
    /// </summary>
    /// <param name="heal">Amount to increase</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }
    /// <summary>
    /// Prints health of player to console
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// Calculates new value of Player's `hp`
    /// </summary>
    /// <param name="newHp">Updated health point value</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

}
