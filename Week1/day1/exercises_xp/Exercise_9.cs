using System;

class Exercise_9
{
    public static void NumberSwapper()
    {
     int a = 4;
     int b = 8;
     
     Console.WriteLine($"before swap a = {a},b = {b}");
     int temp = a;
     a=b;
     b = temp;
     Console.WriteLine($"after swap a = {a},b = {b}");
    }
}
