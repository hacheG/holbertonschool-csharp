using System.Collections.Generic;
using System;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> myListBool = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0){
                myListBool.Add(true);
            }
            else{
                myListBool.Add(false);
            }
        }
        return myListBool;
    }
}

