using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == 0 || myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            myList.Sort();
            int max = myList[myList.Count-1];
            return max;
        }
    }
}