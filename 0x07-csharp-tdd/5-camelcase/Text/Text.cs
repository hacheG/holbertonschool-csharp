using System;

namespace Text
{
	///<summary>Class for string operations</summary>
	public class Str
	{
		///<summary>Returns the number of words in the string</summary>
		public static int CamelCase(string s)
		{
			if (s == "" || s == null)
			{
				return 0;
			}
			int count = 1;
			foreach (char c in s)
			{
				if (Char.IsUpper(c))
				{
					count++;
				}
			}
			return count;
		}
	}
}
