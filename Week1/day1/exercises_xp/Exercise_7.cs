using System;

class Exercise_7
{
    public static void EvenorOdd()

    {
        for (int i = 1; i<=10; i++)
        {
            if (i % 2 ==0)
            {
                Console.WriteLine(i+"  Even");
            }
            else
            {
                Console.WriteLine(i+"  Odd");
            }
        }
    }
    
}