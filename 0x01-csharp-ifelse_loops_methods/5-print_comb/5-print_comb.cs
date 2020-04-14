using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <=9; j++)
                {
                    if (i == 9 && j == 9)
                    {
                        Console.Write("{0}{1} \n", i, j);
                    }
                    else 
                    {
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
        }
    }
}
