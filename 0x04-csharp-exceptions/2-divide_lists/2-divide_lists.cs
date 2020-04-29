using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> resultList = new List<int>();

		for (int i = 0; i < listLength; i++)
		{
			try
			{
				resultList.Add(list1[i] / list2[i]);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Cannot divide by zero");
				resultList.Add(0);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Out of range");
			}
		}
		return resultList;
	}
}
