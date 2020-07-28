using System;

///<summary>Class for que opperations</summary>
class Queue<T>
{
	//Setting node for queues
	public class Node
	{
		public T value = default(T);
		public Node next = null;

		public Node(T input)
		{
			value = input;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	///<summary>Add new node at the end</summary>
	public void Enqueue(T value)
	{
		Node node = new Node(value);
		if (head == null)
		{
			head = node;
			tail = node;
		}
		else
		{
			tail.next = node;
			tail = node;
		}
		count++;
	}

	///<summary>Add deleting the last node</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}

	///<summary>Return the value of first node</summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}

	///<summary>Print all nodes</summary>
	public void Print()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			while (head != null)
			{
				Console.WriteLine(head.value);
				head = head.next;
			}
		}
	}

	///<summary>concatinating string or char else return null</summary>
	public string Concatenate()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return null;
		}
		else if (CheckType() != typeof(char) && CheckType() != typeof(string))
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
			return null;
		}
		else
		{
			string s = "";
			if (CheckType() == typeof(char))
			{
				while (head != null)
				{
					s += head.value;
					head = head.next;
				}
			}
			else if (CheckType() == typeof(string))
			{
				string space = "";
				while (head != null)
				{
					s += space + head.value;
					head = head.next;
					space = " ";
				}
			}
			return s;
		}
	}

	///<summary>Add new node at the end</summary>
	public int Count()
	{
		return count;
	}

	///<summary>Check if its a queue type</summary>
	///<return>returns a Queue type</return>
	public Type CheckType()
	{
		return typeof(T);
	}
}
