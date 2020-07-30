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
        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
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
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    public EventHandler<CurrentHPArgs> HPCheck;
    private string status;
    /// <summary>
    /// Outputs message with information about health points
    /// </summary>
    /// <param name="sender">calling this method</param>
    /// <param name="e">args</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }
        Console.WriteLine(status);
    }

    /// <summary>
    /// If HP is below a quarter of max hp then warns
    /// </summary>
    /// <param name="sender">Object calling this method</param>
    /// <param name="e">Arguments containing current hp</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary>
    /// Adds HPValueWarning method to HPCheck event if below 1/4 hp
    /// </summary>
    /// <param name="e">Arguments with current hp</param>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
        {
            HPCheck += HPValueWarning;
        }

        HPCheck(this, e);
    }
}
/// <summary>
/// class that inherits from EventArgs
/// </summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    /// <summary>
    /// constructor that takes a float newHp and sets it as currentHp‘s value 
    /// </summary>
    /// <param name="newHp">new hp value</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
