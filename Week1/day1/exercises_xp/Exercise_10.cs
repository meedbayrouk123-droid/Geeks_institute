using System;
class Exercise_10
{
    public static void Multiple()
    {
    Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine());
    for(int i = 1;i<=10;i++)
        {
            Console.WriteLine($"{number} multiple {i} equals: {number*i} ");
        }
    }
}