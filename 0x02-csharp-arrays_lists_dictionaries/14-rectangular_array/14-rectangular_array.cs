using System;

class Program
{
	static void Main(string[] args)
	{
		int[,] array = new int[5, 5];
		array[2, 2] = 1;
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("{0} {1} {2} {3} {4}", array[i, 0], array[i, 1], array[i, 2], array[i, 3], array[i, 4]);
		}
	}
}
