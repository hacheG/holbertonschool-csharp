using System;
using System.Collections.Generic;

///<summary>Class for object testing</summary>
class Obj
{
	///<summary>check if its an integrer</summary>
	///<returns>True or false</returns>
	public static bool IsOfTypeInt(object obj)
	{
		return obj is int;
	}
}