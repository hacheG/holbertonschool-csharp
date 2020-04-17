using System.Linq;
using System.Collections.Generic;
using System;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList.Count == 0)
        {
            return -1;
        }

        if (index < 0 || index > myList.Count-1)
        {
            return -1;
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

