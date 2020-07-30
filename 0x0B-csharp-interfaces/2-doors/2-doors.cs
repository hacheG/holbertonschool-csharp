using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Base class</summary>
abstract class Base
{
	public string name = "";

	public override string ToString()
	{
		return String.Format("{0} is a {1}", name, this.GetType().Name);
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

class Door : Base, IInteractive
{
	public Door(string n = "Door")
	{
		this.name = n;
	}

	public void Interact()
	{
		Console.WriteLine("You try to open the {0}. It's locked.", this.name);
	}
}
