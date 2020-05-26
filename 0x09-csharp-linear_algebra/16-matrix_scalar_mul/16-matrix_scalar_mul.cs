using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating applying scalar on matrix</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			double[,] result = {
				{0, 0},
				{0, 0}
			};
			result[0, 0] = matrix[0, 0] * scalar;
			result[0, 1] = matrix[0, 1] * scalar;
			result[1, 0] = matrix[1, 0] * scalar;
			result[1, 1] = matrix[1, 1] * scalar;
			return result;
		}
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double[,] result = {
				{0, 0, 0},
				{0, 0, 0},
				{0, 0, 0}
			};
			result[0, 0] = matrix[0, 0] * scalar;
			result[0, 1] = matrix[0, 1] * scalar;
			result[0, 2] = matrix[0, 2] * scalar;
			result[1, 0] = matrix[1, 0] * scalar;
			result[1, 1] = matrix[1, 1] * scalar;
			result[1, 2] = matrix[1, 2] * scalar;
			result[2, 0] = matrix[2, 0] * scalar;
			result[2, 1] = matrix[2, 1] * scalar;
			result[2, 2] = matrix[2, 2] * scalar;
			return result;
		}
		return new double[,] { { -1 } };
	}
}