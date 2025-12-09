using System;
class Exercise_8
{
    public static void FTemperature()
    {

        Console.WriteLine("Enter a temperature in Celsius");
        int temp = int.Parse(Console.ReadLine());
        int F = temp * 9 / 5 + 32;
        Console.WriteLine("The temperature in Fahrenheit is: "+F);

    }
}