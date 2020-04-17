using System.Collections.Generic;
using System;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList.Count == 0 || index < 0 || index > myList.Count-1)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        else
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (i == index)
                {
                    myList.Remove(myList[i]);
                }
            }
            return myList;
        }
    }
}

