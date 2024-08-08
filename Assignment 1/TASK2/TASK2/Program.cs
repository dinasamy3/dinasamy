// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter an integer: ");
        int num =int.Parse(Console.ReadLine());
     
         if (num < 0)
            {
                Console.WriteLine("negative");
            }
     
   
         
            else
            {
                Console.WriteLine("positive");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
    