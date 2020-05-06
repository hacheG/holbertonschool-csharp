using System;

namespace Text
{
	///<summary>Class for string operations</summary>
	public class Str
	{
		///<summary>getting first unique index</summary>
		public static int UniqueChar(string s)
		{
			if (s == "" || s == null)
			{
				return -1;
			}

			char pre = s[0];
			for (int index = 0; index < s.Length; index++)
			{
				if (s[index] != pre)
				{
					return index;
				}
				pre = s[index];
			}
			return -1;
		}
	}
}

