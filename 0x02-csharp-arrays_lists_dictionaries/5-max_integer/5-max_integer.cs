using System;
using System.Collections.Generic;

class PList
{
    public static int MaxInteger(List<int> myList)
    {
        int i, max = 0;

        for (i = 0; i < myList.Count; i++)
        {
            if (myList[i] > max)
            {
                max = myList[i];
            }
        }
        return max;
    }
}