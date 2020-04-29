using System;

public enum Rating { Good, Great, Excellent }
public struct Dog
{
	public string name;
	public float age;
	public string owner;
	public Rating rating;
	public Dog(string n, float a, string o, Rating r)
	{
		name = n;
		age = a;
		owner = o;
		rating = r;
	}
	public override string ToString()
	{
		return String.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
	}
}
