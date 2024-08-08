// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        try
        {
         
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            
            int maxElement = Math.Max(num1, Math.Max(num2, num3));
            int minElement = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine("Max element = " + maxElement);
            Console.WriteLine("Min element = " + minElement);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid integers.");
        }
    }
}

