using System;


class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length == 0 || length < 0)
        {
            Console.WriteLine("");
        }
        else
        {
            for (int i = 0; i < length; i++)
            {   
                Console.WriteLine("\\");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                
                Console.Write(" ");
            }
            Console.WriteLine(" ");
        }
    }
}

