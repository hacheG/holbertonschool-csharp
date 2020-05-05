using System;

namespace MyMath
{
    ///<summary>qwertywqerty</summary>
    public class Matrix
    {
        ///<summary>qwertyqwerty</summary>
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (num == 0)
			{
				Console.WriteLine("Num cannot be 0");
				return null;
			}
			if (matrix == null)
			{
				return null;
			}
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i, j] / num;
				}
			}
			return matrix;
    }
}
