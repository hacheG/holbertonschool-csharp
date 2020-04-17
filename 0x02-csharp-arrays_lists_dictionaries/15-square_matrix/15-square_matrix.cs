using System;

class Matrix
{
	public static int[,] Square(int[,] myMatrix)
	{
		int row = myMatrix.GetLength(0);
		int column = myMatrix.GetLength(1);
		int[,] newMatrix = new int[row, column];
		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < column; j++)
			{
				newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
			}
		}
		return newMatrix;
	}
}
