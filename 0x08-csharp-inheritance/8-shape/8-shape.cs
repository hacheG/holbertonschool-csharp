using System;

///<summary>Class for Shapes</summary>
class Shape
{
	//setting an error if method is not modified
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

	//return Area of rectangle
	public new int Area()
	{
		return width * height;
	}

	//overide string method
	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}


///<summary>Class Rectangle inheriting from Shape</summary>
class Square : Rectangle
{
	private int size;

	//size of width and height of square
	public int Size
	{
		get
		{
			return size;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Size must be greater than or equal to 0");
			}
			size = value;
			Height = value;
			Width = value;
		}
	}
}