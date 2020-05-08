using System;

///<summary>Class for Shapes</summary>
class Shape
{
	///<summary>Just throws error</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}