using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int max = 0;
		string result = "None";
		if (myList.Count <= 0)
		{
			return result;
		}
		foreach (KeyValuePair<string, int> kvp in myList)
		{
			if (max <= kvp.Value)
			{
				max = kvp.Value;
				result = kvp.Key;
			}
		}
		return result;
	}
}
