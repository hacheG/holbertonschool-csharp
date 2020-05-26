using System;

///<summary>Class for vector math</summary>
class VectorMath
{
	///<summary>calcuating vetor dot product</summary>
	///<return>the result dot product or -1</return>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length == 2 && vector2.Length == 2)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1];
		}
		else if (vector1.Length == 3 && vector2.Length == 3)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
		}
		return -1;
	}
}