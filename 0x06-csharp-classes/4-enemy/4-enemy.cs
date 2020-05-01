using System;

namespace Enemies
{
	///<summary>creating zombie class.</summary>
	public class Zombie
	{
		///<summary>public field health of zombie.</summary>
		private int health;
		///<summary>public constructor for zombie.</summary>
		public Zombie()
		{
			health = 0;
		}
		///<summary>public constructor for zombie with value input.</summary>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			else
			{
				health = value;
			}
		}
		///<summary>public field name of zombie.</summary>
		private string name = "(No name)";
		///<summary>public property Name of zombie.</summary>
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		///<summary>public method GetHealth to reutrn health of zomibe.</summary>
		public int GetHealth()
		{
			return health;
		}
	}
}