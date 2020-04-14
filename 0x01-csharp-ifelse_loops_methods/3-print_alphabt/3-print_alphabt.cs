using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 122; i++)
            {
                char j = Convert.ToChar(i);
                if (j == 'q' || j == 'e')
                {
                    continue;
                }
                else 
                {
                    Console.Write(j);
                }
            }
        }
    }
}