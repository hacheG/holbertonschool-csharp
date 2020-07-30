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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability { get; set; }
	public bool isCollected { get; set; }

	public void Interact()
	{

	}

	public void Break()
	{

	}

	public void Collect()
	{

	}
}
