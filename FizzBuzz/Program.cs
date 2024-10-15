using System;

class Program
{


    static void Main(string[] args)
    {
        FizzBuzz(100);
    }

    static void FizzBuzz(int num)
    {
        for (int i = 0; i < num; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }
}
