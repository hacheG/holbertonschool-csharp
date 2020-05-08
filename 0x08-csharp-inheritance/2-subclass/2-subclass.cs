using System;

///<summary>Class for object testing</summary>
class Obj
{
	///<summary>check if its a subclass of base</summary>
	///<returns>True or false</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		return derivedType.IsSubclassOf(baseType);
	}
}