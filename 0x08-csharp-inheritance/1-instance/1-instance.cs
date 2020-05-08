using System;
using System.Collections.Generic;

///<summary>Class for object testing</summary>
class Obj
{
	///<summary>ckeck if object is array</summary>
	///<returns>True or false</returns>
	public static bool IsInstanceOfArray(object obj)
	{
		return typeof(Array).IsInstanceOfType(obj);
	}
}