
using System;

public class Exercise_4

 {
     public static void UserAge()
     {
         Console.WriteLine("Enter your age");
         int userage= int.Parse(Console.ReadLine());
         if(userage>=18)

         
         {
             Console.WriteLine("Access Granted");
         }

          else
         {
             Console.WriteLine("Access Denied");
         }
         
     }
 }