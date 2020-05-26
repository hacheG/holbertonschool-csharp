using System;

///<summary>Class for vector math</summary>
class VectorMath
{
	///<summary>calcuating vetor scaling</summary>
	///<return>the result vector or vector containing -1</return>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length == 2)
		{
			double[] result = { 0, 0 };
			result[0] = vector[0] * scalar;
			result[1] = vector[1] * scalar;
			return result;
		}
		else if (vector.Length == 3)
		{
			double[] result = { 0, 0, 0 };
			result[0] = vector[0] * scalar;
			result[1] = vector[1] * scalar;
			result[2] = vector[2] * scalar;
			return result;
		}
		return new double[] { -1 };
	}
}