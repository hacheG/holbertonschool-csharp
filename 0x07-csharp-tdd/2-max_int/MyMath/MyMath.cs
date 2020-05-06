using System;
using System.Collections.Generic;

namespace MyMath
{
	///<summary>qwertyqwerty</summary>
	public class Operations
	{
		///<summary>qwertyqwerty</summary>
		public static int Max(List<int> nums)
		{
			if (nums == null || nums.Count == 0)
			{
				return 0;
			}
			int max = nums[0];

			foreach (int i in nums)
			{
				max = i > max ? i : max;
			}
			return max;
		}
	}
}
