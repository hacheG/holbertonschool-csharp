using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		Dictionary<string, int> result = new Dictionary<string, int>();
		foreach (KeyValuePair<string, int> kvp in myDict)
		{
			result[kvp.Key] = kvp.Value * 2;
		}
		return result;
	}
}
