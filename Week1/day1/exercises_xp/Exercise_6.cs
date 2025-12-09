using System;
class Exercise_6
{
    
    public static void SayHello()
    {
        string[] names= {"Ahmed","Ali","Saad"};
        
        
        for (int i = 0; i<names.Length ; i++)
        {
            Console.WriteLine("Hello"+names[i]);
            
        }
    }
}