using System;

class Program
{
    private const double V = 0.001;

    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastNum;

        lastNum = number % 10;

        if (lastNum > 5)
        {
            Console.WriteLine("The last digit of {0} is {1} and is greater than 5", number, lastNum);
        }
        
        else if (lastNum == 0)
        {
            Console.WriteLine("The last digit of {0} is {1} and is 0", number, lastNum);
        }

        else if (lastNum < 6 && lastNum != 0)
        {
            Console.WriteLine("The last digit of {0} is {1} and is less than 6 and not 0", number, lastNum);
        }
    }
}
