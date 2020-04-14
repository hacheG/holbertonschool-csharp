using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int val = number % 10;
        if (val < 0)
        {
            val = val * -1;
            Console.Write(val);
            return val; 
        }
        Console.Write(val);
        return val;
    }
}