﻿using System;

///<summary>Class for Shapes</summary>
class Shape
{
	///<summary>Just throws error</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

///<summary>Class Rectangle inheriting from Shape</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	//width of rectangle
	public int Width
	{
		get
		{
			return width;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			width = value;
		}
	}

	//height of rectangle
	public int Height
	{
		get
		{
			return height;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0");
			}
			height = value;
		}
	}

	///<summary>returns area of rectangle</summary>
	public new int Area()
	{
		return width * height;
	}

	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}