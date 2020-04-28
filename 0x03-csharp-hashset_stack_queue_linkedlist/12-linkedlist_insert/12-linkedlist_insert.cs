using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> current = myLList.First;
		while (current != null)
		{
			if (n < current.Value)
			{
				return myLList.AddBefore(current, n);
			}
			current = current.Next;
		}
		return myLList.AddLast(n);
	}
}
