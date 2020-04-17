using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        myList.Sort();
        int max = myList[myList.Count-1];
        return max;
        
    }
}