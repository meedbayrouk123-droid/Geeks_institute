using System;

class Exercise1
{
    public static void Run()
    {
        Console.WriteLine("Enter a number between 1 and 100");
        int input = int.Parse(Console.ReadLine());
        if (input % 3 == 0 && input % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (input % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (input % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
    }
}
