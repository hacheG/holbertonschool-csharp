using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		SortedList<string, string> keys = new SortedList<string, string>(myDict);
		foreach (KeyValuePair<string, string> kvp in keys)
		{
			Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
		}
	}
}
