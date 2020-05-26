using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating matrix multiplication</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int m1_row = matrix1.GetLength(0);
		int m1_col = matrix1.GetLength(1);
		int m2_row = matrix2.GetLength(0);
		int m2_col = matrix2.GetLength(1);
		if (m1_col == m2_row)
		{
			double[,] result = new double[m1_row, m2_col];
			for (int i = 0; i < m1_row; i++)
			{
				for (int j = 0; j < m2_col; j++)
				{
					for (int k = 0; k < m1_col; k++)
					{
						result[i, j] += matrix1[i, k] * matrix2[k, j];
					}
				}
			}
			return result;
		}
		return new double[,] { { -1 } };
	}
}