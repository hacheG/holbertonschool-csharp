using System.Collections.Generic;
using System;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
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

