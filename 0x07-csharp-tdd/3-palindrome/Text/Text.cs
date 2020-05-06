using System;
using System.Text.RegularExpressions;

namespace Text
{
	///<summary>qwertyqwerty</summary>
	public class Str
	{
		///<summary>qwertywerty</summary>
		public static bool IsPalindrome(string s)
		{
			s = Regex.Replace(s, "[^A-Za-z]", "");

			char[] array = s.ToCharArray();
			Array.Reverse(array);

			return s.ToLower() == new string(array).ToLower();
		}
	}
}
