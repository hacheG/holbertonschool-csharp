using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        size = Convert.ToInt32(size);
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            return arr;  
        }
    }
}
