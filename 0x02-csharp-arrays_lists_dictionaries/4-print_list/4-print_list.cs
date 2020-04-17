using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> miList = new List<int>();
           for (int i = 0; i < size; i++)
            {
                miList.Add(i);
                if ( i != size-1)
                {
                    Console.Write(miList[i] + " ");
                }
                else
                {
                    Console.Write(miList[i]);
                }
            }
            Console.WriteLine("");
            return miList;
        }
        
        
    }
}
