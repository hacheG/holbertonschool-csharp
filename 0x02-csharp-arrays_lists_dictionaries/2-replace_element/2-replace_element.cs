using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index > array.Length-1)
        {
            return array;
        }
        else
        {
            array[index] = n;
            return array;
        }
        
    }
}
