using System;

/// <summary>
/// Cretes public class called `Player`
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// Constructor to assign parameters to properties
    /// </summary>
    /// <param name="name">Player name</param>
    /// <param name="maxHp">Maximum Player health points (hp)</param>
    public Player(string name = "Player", float maxHp = 100f)
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
    /// Prints health of player to console
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
