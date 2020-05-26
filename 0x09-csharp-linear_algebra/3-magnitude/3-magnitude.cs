using System;

///<summary>Class for VectorMath</summary>
class VectorMath
{
	///<summary>calcuating magnitude for 2d and 3d vector</summary>
	///<return>the magnitude or -1</return>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length == 2)
		{
			double result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
			return Math.Round(result, 2);
		}
		else if (vector.Length == 3)
		{
			double result = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
			return Math.Round(result, 2);
		}
		return -1;
	}
}