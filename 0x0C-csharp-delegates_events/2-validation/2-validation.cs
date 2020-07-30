using System;
/// <summary>
/// Delegate to track hp of player
/// </summary>
/// <param name="amount">Amount of hp affected</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Cretes public class called `Player`
/// </summary>
class Player
{
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
