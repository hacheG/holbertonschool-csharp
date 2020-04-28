using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> myList1 = list1.FindAll(elem => !list2.Contains(elem));
		List<int> myList2 = list2.FindAll(elem => !list1.Contains(elem));
		myList1.AddRange(myList2);
		myList1.Sort();
		return myList1;
	}
}
